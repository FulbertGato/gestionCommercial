using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace gestion_com_2022.utils
{
   public  class NotificationSend
    {

       /* public void  smsSend()
        {
            var client = new RestClient("https://gateway.intechsms.sn/api/send-sms");
            client.Timeout = -1;
            var request = new RestRequest(Method.Post);
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
            Console.WriteLine(response.Content);
        }*/



        public void emailSend(String receive, String objetMail, string message)
        {

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("clinique221ism@gmail.com");
                mail.To.Add(receive);
                mail.Subject = objetMail;
                mail.Body = message;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("clinique221ism@gmail.com", "Azer1234");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
               // MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.ToString());
            }
        }
    }
}
