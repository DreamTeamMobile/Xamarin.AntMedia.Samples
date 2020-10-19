using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using DE.Tavendo.Autobahn;
using IO.Antmedia.Webrtcandroidframework;
using IO.Antmedia.Webrtcandroidframework.Apprtc;
using Java.Interop;
using Java.Util;
using Org.Webrtc;
using Andr = Android;
using Log = Android.Util.Log;
using DT.Configuration;

namespace DT.WebRTC.Droid
{
    //[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    //public class MainActivity : AppCompatActivity
    [Activity(MainLauncher = true)]
    public class MainActivity : Activity, IWebRTCListener
    {
        /**
         * Mode can Publish, Play or P2P
         */
        private String webRTCMode = WebRTCClientConsts.ModePublish;

        private CallFragment callFragment;

        private WebRTCClient webRTCClient;

        private Button startStreamingButton;
        private String operationName = "";
        private Timer timer;
        private String streamId;

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

            SetContentView(Resource.Layout.activity_main);
            SurfaceViewRenderer cameraViewRenderer = FindViewById<SurfaceViewRenderer>(Resource.Id.camera_view_renderer);
            SurfaceViewRenderer pipViewRenderer = FindViewById<SurfaceViewRenderer>(Resource.Id.pip_view_renderer);

            startStreamingButton = (Button)FindViewById(Resource.Id.start_streaming_button);

            // Check for mandatory permissions.
            foreach (String permission in CallActivity.MandatoryPermissions)
            {
                if (this.CheckCallingOrSelfPermission(permission) != Andr.Content.PM.Permission.Granted)
                {
                    Toast.MakeText(this, "Permission " + permission + " is not granted", ToastLength.Short).Show();
                    return;
                }
            }

            if (webRTCMode.Equals(WebRTCClientConsts.ModePublish))
            {
                startStreamingButton.Text = "Start Publishing";
                operationName = "Publishing";
            }
            else if (webRTCMode.Equals(WebRTCClientConsts.ModePlay))
            {
                startStreamingButton.Text = "Start Playing";
                operationName = "Playing";
            }
            else if (webRTCMode.Equals(WebRTCClientConsts.ModeJoin))
            {
                startStreamingButton.Text = "Start P2P";
                operationName = "P2P";
            }
            Intent.PutExtra(CallActivity.ExtraCapturetotextureEnabled, true);
            Intent.PutExtra(CallActivity.ExtraVideoFps, 30);
            Intent.PutExtra(CallActivity.ExtraVideoBitrate, 2500);
            Intent.PutExtra(CallActivity.ExtraCapturetotextureEnabled, true);

            webRTCClient = new WebRTCClient(this, this);

            //webRTCClient.setOpenFrontCamera(false);

            streamId = InitialData.DefaultStream;
            String tokenId = InitialData.Token;//"tokenId";
            webRTCClient.SetVideoRenderers(pipViewRenderer, cameraViewRenderer);
            webRTCClient.SetOpenFrontCamera(true);
            // Intent.PutExtra(CallActivity.EXTRA_VIDEO_FPS, 24);
            webRTCClient.Init(InitialData.SERVER_URL, streamId, webRTCMode, tokenId, Intent);
        }

        [Export("StartStreaming")]
        public void StartStreaming(View v)
        {

            if (!webRTCClient.IsStreaming)
            {
                ((Button)v).Text = "Stop " + operationName;
                webRTCClient.StartStream();
            }
            else
            {
                ((Button)v).Text = "Start " + operationName;
                webRTCClient.StopStream();
            }
        }

        [Export("ModeJoin")]
        public void ModeJoin(View v)
        {
            webRTCMode = WebRTCClientConsts.ModeJoin;
            startStreamingButton.Text = "Start " + operationName;
            webRTCClient.StopStream();
        }

        [Export("ModePlay")]
        public void ModePlay(View v)
        {
            webRTCMode = WebRTCClientConsts.ModePlay;
            startStreamingButton.Text = "Start " + operationName;
            webRTCClient.StopStream();
        }

        [Export("ModePublish")]
        public void ModePublish(View v)
        {
            webRTCMode = WebRTCClientConsts.ModePublish;
            startStreamingButton.Text = "Start " + operationName;
            webRTCClient.StopStream();
        }

        public void OnPlayStarted()
        {
            Log.WriteLine(Andr.Util.LogPriority.Info, this.Class.SimpleName, "onPlayStarted");
            Toast.MakeText(this, "Play started", ToastLength.Long).Show();
            webRTCClient.SwitchVideoScaling(RendererCommon.ScalingType.ScaleAspectFit);
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
            Finish();
        }


        public void OnError(String description)
        {
            Toast.MakeText(this, "Error: " + description, ToastLength.Long).Show();
        }


        protected override void OnStop()
        {
            base.OnStop();
            webRTCClient.StopStream();
        }


        public void OnSignalChannelClosed(WebSocketWebSocketConnectionObserverWebSocketCloseNotification code)
        {
            Toast.MakeText(this, "Signal channel closed with code " + code, ToastLength.Long).Show();
        }


        public void OnDisconnected()
        {

            Log.WriteLine(Andr.Util.LogPriority.Info, this.Class.SimpleName, "disconnected");
            Toast.MakeText(this, "Disconnected", ToastLength.Long).Show();

            startStreamingButton.Text = "Start " + operationName;
            //finish();
        }


        public void OnIceConnected()
        {
            //it is called when connected to ice
        }


        public void OnIceDisconnected()
        {
            //it's called when ice is disconnected
        }

        public void OnOffVideo(View view)
        {
            if (webRTCClient.IsVideoOn)
            {
                webRTCClient.DisableVideo();
            }
            else
            {
                webRTCClient.EnableVideo();
            }
        }

        public void OnOffAudio(View view)
        {
            if (webRTCClient.IsAudioOn)
            {
                webRTCClient.DisableAudio();
            }
            else
            {
                webRTCClient.EnableAudio();
            }
        }


        public void OnTrackList(String[] tracks)
        {

        }


        public void OnBitrateMeasurement(String streamId, int targetBitrate, int videoBitrate, int audioBitrate)
        {
            Log.WriteLine(Andr.Util.LogPriority.Info, this.Class.SimpleName, "st:" + streamId + " tb:" + targetBitrate + " vb:" + videoBitrate + " ab:" + audioBitrate);
            if (targetBitrate < (videoBitrate + audioBitrate))
            {
                Toast.MakeText(this, "low bandwidth", ToastLength.Short).Show();
            }
        }

        /**
         * This method is used in an experiment. It's not for production
         * @param streamId
         */
        //public void calculateAbsoluteLatency(String streamId) {
        //    String url = REST_URL + "/broadcasts/" + streamId + "/rtmp-to-webrtc-stats";

        //    RequestQueue queue = Volley.newRequestQueue(this);


        //    StringRequest stringRequest = new StringRequest(Request.Method.GET, url,
        //            new Response.Listener<String>() {

        //                public void onResponse(String response) {
        //                    try {
        //                        Log.i("MainActivity", "recevied response " + response);
        //                        JSONObject jsonObject = new JSONObject(response);
        //                        long absoluteStartTimeMs = jsonObject.getLong("absoluteTimeMs");
        //                        //this is the frame id in sending the rtp packet. Actually it's rtp timestamp
        //                        long frameId = jsonObject.getLong("frameId");
        //                        long relativeCaptureTimeMs = jsonObject.getLong("captureTimeMs");
        //                        long captureTimeMs = frameId / 90;
        //                        Map<Long, Long> captureTimeMsList = WebRTCClient.getCaptureTimeMsMapList();

        //                        long absoluteDecodeTimeMs = 0;
        //                        if (captureTimeMsList.containsKey(captureTimeMs)) {
        //                            absoluteDecodeTimeMs = captureTimeMsList.get(captureTimeMs);
        //                        }

        //                        long absoluteLatency = absoluteDecodeTimeMs - relativeCaptureTimeMs - absoluteStartTimeMs;
        //                Log.WriteLine(Andr.Util.LogPriority.Info, "MainActivity", "recevied absolute start time: " + absoluteStartTimeMs
        //                                                    + " frameId: " + frameId + " relativeLatencyMs : " + relativeCaptureTimeMs
        //                                                    + " absoluteDecodeTimeMs: " + absoluteDecodeTimeMs
        //                                                    + " absoluteLatency: " + absoluteLatency);
        //                    } catch (JSONException e) {
        //                        e.printStackTrace();
        //                    }


        //                }
        //            }, new Response.ErrorListener() {

        //        public void onErrorResponse(VolleyError error) {
        //            Log.e("MainActivity","That didn't work!");

        //        }
        //    });

        //    // Add the request to the RequestQueue.
        //    queue.add(stringRequest);

        //}
    }
}