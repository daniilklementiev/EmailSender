using System.Net;
using System.Net.Mail;

namespace EmailSender
{
    public partial class Form1 : Form
    {
        private MailAddress from;           // отправитель - sender
        private MailAddress to;             // получатель - recipient
        private MailMessage mailMessage;    // сообщение - message
        private SmtpClient smtp;            // клиент для отправки сообщений - client

        public Form1()
        {
            from = new MailAddress("testprogramcsharp@gmail.com", "Daniil"); // sender
            to = new MailAddress("danik1708@ukr.net"); // recipient
            mailMessage = new MailMessage(from, to); // creating message
            mailMessage.Subject = "Test"; // subject
            mailMessage.Body = "<h2>Test mail</h2>"; // body
            mailMessage.IsBodyHtml = true; // html mail
            smtp = new SmtpClient("smtp.gmail.com", 587); // creating smtp client
            smtp.Credentials = new NetworkCredential("testprogramcsharp@gmail.com", "123456"); // assigning login and password
            smtp.EnableSsl = true; // enabling ssl protocol
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            smtp.Send(mailMessage); // sending message
        }
    }
}