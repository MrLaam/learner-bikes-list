using LearnerBikes.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LearnerBikes.Helpers
{
    public class ContactHelper
    {
        public void sendEmail(Contact contact)
        {
            if(contact.senderEmail != null && contact.senderSubject != null && contact.senderMessage != null)
            {
                var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");
                var config = builder.Build();

                var smtpClient = new SmtpClient(config["Smtp:Host"])
            {
                Port = int.Parse(config["Smtp:Port"]),
                Credentials = new NetworkCredential(config["Smtp:Username"], config["Smtp:Password"]),
                EnableSsl = true,
            };

            smtpClient.Send(contact.senderEmail, "jordanlambikes@gmail.com", contact.senderSubject, contact.senderMessage);
            }
            
        }
    }
}
