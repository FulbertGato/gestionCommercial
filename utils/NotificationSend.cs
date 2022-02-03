using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.utils
{
   public  class NotificationSend
    {

        public void  smsSend()
        {
            /*var client = new RestClient("https://gateway.intechsms.sn/api/send-sms");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            var body = @"{" + "\n" +
            @"    ""app_key"":""6074FFEF083EF0830D960740E8""," + "\n" +
            @"    ""sender"":""INTECHSMS""," + "\n" +
            @"    ""content"":""Bonjour""," + "\n" +
            @"    ""msisdn"":[" + "\n" +
            @"        ""+221777293282""," + "\n" +
            @"        ""+221766144307""" + "\n" +
            @"    ]" + "\n" +
            @"}";
            request.AddParameter("text/plain", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);*/
        }
    }
}
