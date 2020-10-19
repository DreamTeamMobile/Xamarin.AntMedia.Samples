
using System;
using System.Collections.Generic;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using DE.Tavendo.Autobahn;
using IO.Antmedia.Webrtcandroidframework;
using IO.Antmedia.Webrtcandroidframework.Apprtc;
using Org.Webrtc;
using Andr = Android;
using Log = Android.Util.Log;

namespace DT.WebRTC.Droid
{
    [Activity(Label = "ConferenceActivity")]
    public class ConferenceActivity : Activity, IWebRTCListener, IDataChannelObserver
    {
        private ConferenceManager conferenceManager;
        private Button audioButton;
        private Button videoButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set window styles for fullscreen-window size. Needs to be done before
            // adding content.
            RequestWindowFeature(WindowFeatures.NoTitle);
            Window.AddFlags(WindowManagerFlags.Fullscreen | WindowManagerFlags.KeepScreenOn
                    | WindowManagerFlags.DismissKeyguard | WindowManagerFlags.ShowWhenLocked
                    | WindowManagerFlags.TurnScreenOn);
            //getWindow().getDecorView().setSystemUiVisibility(getSystemUiVisibility());

            SetContentView(Resource.Layout.activity_conference);

            SurfaceViewRenderer publishViewRenderer = FindViewById<SurfaceViewRenderer>(Resource.Id.publish_view_renderer);
            List<SurfaceViewRenderer> playViewRenderers = new List<SurfaceViewRenderer>();

            playViewRenderers.Add(FindViewById<SurfaceViewRenderer>(Resource.Id.play_view_renderer1));
            playViewRenderers.Add(FindViewById<SurfaceViewRenderer>(Resource.Id.play_view_renderer2));
            playViewRenderers.Add(FindViewById<SurfaceViewRenderer>(Resource.Id.play_view_renderer3));
            playViewRenderers.Add(FindViewById<SurfaceViewRenderer>(Resource.Id.play_view_renderer4));

            audioButton = FindViewById<Button>(Resource.Id.control_audio_button);
            videoButton = FindViewById<Button>(Resource.Id.control_video_button);

            // Check for mandatory permissions.
            foreach (String permission in CallActivity.MandatoryPermissions)
            {
                if (this.CheckCallingOrSelfPermission(permission) != Andr.Content.PM.Permission.Granted)
                {
                    Toast.MakeText(this, "Permission " + permission + " is not granted", ToastLength.Short).Show();
                    return;
                }
            }

            this.Intent.PutExtra(CallActivity.ExtraCapturetotextureEnabled, true);
            //  this.getIntent().putExtra(CallActivity.EXTRA_VIDEO_CALL, false);

            String streamId = null;//"stream1";
            String roomId = "room1";
            conferenceManager = new ConferenceManager(
                    this,
                    this,
                    Intent,
                    "",//MainActivity.SERVER_URL,
                    roomId,
                    publishViewRenderer,
                    playViewRenderers,
                    streamId,
                    this
            );

            conferenceManager.SetOpenFrontCamera(true);
        }


        public void JoinConference(View v)
        {

            if (!conferenceManager.IsJoined)
            {
                Log.WriteLine(Andr.Util.LogPriority.Info, this.Class.SimpleName, "Joining Conference");
                ((Button)v).Text = "Leave";
                conferenceManager.JoinTheConference();
            }
            else
            {
                ((Button)v).Text = "Join";
                conferenceManager.LeaveFromConference();
            }
        }

        public void OnPlayStarted()
        {
            Log.WriteLine(Andr.Util.LogPriority.Info, this.Class.SimpleName, "onPlayStarted");
            Toast.MakeText(this, "Play started", ToastLength.Long).Show();
        }


        public void OnPublishStarted()
        {
            Log.WriteLine(Andr.Util.LogPriority.Info, this.Class.SimpleName, "onPublishStarted");
            Toast.MakeText(this, "Publish started", ToastLength.Long).Show();

        }


        public void OnPublishFinished()
        {
            Log.WriteLine(Andr.Util.LogPriority.Info, this.Class.SimpleName, "onPublishFinished");
            Toast.MakeText(this, "Publish finished", ToastLength.Long).Show();
        }


        public void OnPlayFinished()
        {
            Log.WriteLine(Andr.Util.LogPriority.Info, this.Class.SimpleName, "onPlayFinished");
            Toast.MakeText(this, "Play finished", ToastLength.Long).Show();
        }


        public void NoStreamExistsToPlay()
        {
            Log.WriteLine(Andr.Util.LogPriority.Info, this.Class.SimpleName, "noStreamExistsToPlay");
            Toast.MakeText(this, "No stream exist to play", ToastLength.Long).Show();
        }


        public void OnError(String description)
        {
            Toast.MakeText(this, "Error: " + description, ToastLength.Long).Show();
        }


        protected void OnStop()
        {
            base.OnStop();
            audioButton.Text = "Disable Audio";
            videoButton.Text = "Disable Video";
        }


        public void OnSignalChannelClosed(WebSocketWebSocketConnectionObserverWebSocketCloseNotification code)
        {
            Toast.MakeText(this, "Signal channel closed with code " + code, ToastLength.Long).Show();
        }


        public void OnDisconnected()
        {
            Log.WriteLine(Andr.Util.LogPriority.Info, this.Class.SimpleName, "disconnected");
            Toast.MakeText(this, "Disconnected", ToastLength.Long).Show();
            audioButton.Text = "Disable Audio";
            videoButton.Text = "Disable Video";
        }


        public void OnIceConnected()
        {
            //it is called when connected to ice
        }


        public void OnIceDisconnected()
        {

        }


        public void OnTrackList(String[] tracks)
        {

        }


        public void OnBitrateMeasurement(String streamId, int targetBitrate, int videoBitrate, int audioBitrate)
        {

        }


        public void OnBufferedAmountChange(long previousAmount, String dataChannelLabel)
        {

        }


        public void OnStateChange(DataChannel.State state, String dataChannelLabel)
        {

        }


        public void OnMessage(DataChannel.Buffer buffer, String dataChannelLabel)
        {
            //TODO: fix messaging
            //Java.Nio.ByteBuffer data = buffer.Data;
            //String strDataJson = new String(data.AsCharBuffer().ToArray, StandardCharsets.UTF_8);

            //try
            //{
            //    JSONObject json = new JSONObject(strDataJson);
            //    String eventType = json.getString("eventType");
            //    String streamId = json.getString("streamId");
            //    Toast.MakeText(this, eventType + " : " + streamId, ToastLength.Long).Show();
            //}
            //catch (Exception e)
            //{
            //    Log.e(getClass().getSimpleName(), e.getMessage());
            //}
        }


        public void OnMessageSent(DataChannel.Buffer buffer, bool successful)
        {
            //TODO: fix messaging
            //ByteBuffer data = buffer.data;
            //String strDataJson = new String(data.array(), StandardCharsets.UTF_8);

            //Log.e(getClass().getSimpleName(), "SentEvent: " + strDataJson);
        }

        public void ControlAudio(View view)
        {
            if (conferenceManager.IsPublisherAudioOn)
            {
                conferenceManager.DisableAudio();
                audioButton.Text = "Enable Audio";
            }
            else
            {
                conferenceManager.EnableAudio();
                audioButton.Text = "Disable Audio";
            }
        }

        public void ControlVideo(View view)
        {
            if (conferenceManager.IsPublisherVideoOn)
            {
                conferenceManager.DisableVideo();
                videoButton.Text = "Enable Video";

            }
            else
            {
                conferenceManager.EnableVideo();
                videoButton.Text = "Disable Video";
            }
        }
    }
}
