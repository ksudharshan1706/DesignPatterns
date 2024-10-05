using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralDP.Facade_DP.RealTimeExample
{
    public class Email
    {
        public void sendRegistrationEmail(Customer customer)
        {
            string custEmail = customer.getCustEmail();
            // Email settings (your own email credentials)
            string senderEmail = "kamavaramsudharshan1706@gmail.com";  // Replace with your Gmail email address
            string senderPassword = "Sudha#123";  // Replace with your Gmail app password

            // Define the email content
            string subject = "Registration Confirmation";
            string body = "Thank you for registering with us!";

            // Set up the mail message
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderEmail);  // Sender's email
            mail.To.Add(custEmail);               // Recipient's email (customer)
            mail.Subject = subject;                   // Subject of the email
            mail.Body = body;                         // Body content of the email

            // Set up the SMTP client
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)  // Gmail SMTP server and port
            {
                Credentials = new NetworkCredential(senderEmail, senderPassword),  // Sender's email credentials
                EnableSsl = true  // Enabling SSL for secure transmission
            };

            try
            {
                smtpClient.Send(mail);  // Send the email
                Console.WriteLine("Registration email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }
        }
    }
}
