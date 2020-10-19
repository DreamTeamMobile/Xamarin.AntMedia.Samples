﻿using System;

namespace DT.Configuration
{
    public class InitialData
    {
        public const string SERVER_ADDRESS = "antmedia.drmtm.us:5080";
        public const string SERVER_URL = "ws://" + SERVER_ADDRESS + "/WebRTCAppEE/websocket";
        public const string REST_URL = "http://" + SERVER_ADDRESS + "/WebRTCAppEE/rest/v2";
        public const string DefaultStream = "stream1";
        public const string Token = "";
    }
}
