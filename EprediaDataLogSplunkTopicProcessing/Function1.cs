using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EprediaDataLogSplunkTopicProcessing
{
    public static class Function1
    {


        [FunctionName("Function1")]
        public static void Run([ServiceBusTrigger("revostissueprocessortelemetrymessages", "revosTissueProcessorTelemetryMessagesSusbcription", Connection = "telemetryMessagesConnectionString")] string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");

            Rootobject jsonObject = JsonConvert.DeserializeObject<Rootobject>(mySbMsg);            
        }
    }
}
