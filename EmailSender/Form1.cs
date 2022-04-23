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
            from = new MailAddress("testprogramcsharp@gmail.com", "Daniil"); // отправитель - sender
            to = new MailAddress("danik1708@ukr.net"); // получатель - recipient
            mailMessage = new MailMessage(from, to); // создаем сообщение - creating message
            mailMessage.Subject = "Test"; // тема сообщения - subject
            mailMessage.Body = "<h2>Test mail</h2>"; // тело сообщения - body
            mailMessage.IsBodyHtml = true; // письмо в виде html - html mail
            smtp = new SmtpClient("smtp.gmail.com", 587); // создаем клиента для отправки сообщений - creating smtp client
            smtp.Credentials = new NetworkCredential("testprogramcsharp@gmail.com", "123456"); // присваиваем логин и пароль - assigning login and password
            smtp.EnableSsl = true; // включаем протокол ssl - enabling ssl protocol
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            smtp.Send(mailMessage); // отправляем сообщение - sending message
        }
    }
}