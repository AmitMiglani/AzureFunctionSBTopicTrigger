using System;
using System.Collections.Generic;
using System.Text;

namespace EprediaDataLogSplunkTopicProcessing
{


    public class Rootobject
    {
        public string id { get; set; }
        public string topic { get; set; }
        public string subject { get; set; }
        public string eventType { get; set; }
        public Data data { get; set; }
        public string dataVersion { get; set; }
        public string metadataVersion { get; set; }
        public DateTime eventTime { get; set; }
    }

    public class Data
    {
        public Properties properties { get; set; }
        public Systemproperties systemProperties { get; set; }
        public Body body { get; set; }
    }

    public class Properties
    {
        public string deviceType { get; set; }
        public string request { get; set; }
        public string datatype { get; set; }
        public string eventKey { get; set; }
    }

    public class Systemproperties
    {
        public string iothubcontenttype { get; set; }
        public string iothubcontentencoding { get; set; }
        public string iothubconnectiondeviceid { get; set; }
        public string iothubconnectionauthmethod { get; set; }
        public string iothubconnectionauthgenerationid { get; set; }
        public DateTime iothubenqueuedtime { get; set; }
        public string iothubmessagesource { get; set; }
    }

    public class Body
    {
        public string request { get; set; }
        public string deviceType { get; set; }
        public string datatype { get; set; }
        public string id { get; set; }
        public string eventKey { get; set; }
        public DateTime timestamp { get; set; }
        public Eventparameters eventParameters { get; set; }
    }

    public class Eventparameters
    {
        public string Log_event_1 { get; set; }
        public string Log_event_2 { get; set; }
        public string Log_event_3 { get; set; }
        public string Log_event_4 { get; set; }
    }

}
