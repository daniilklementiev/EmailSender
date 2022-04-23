using System.Net;
using System.Net.Mail;

namespace EmailSender
{
    public partial class Form1 : Form
    {
        private MailAddress from;           // отправитель
        private MailAddress to;             // получатель
        private MailMessage mailMessage;    // сообщение
        private SmtpClient smtp;            // клиент для отправки сообщений
        
        public Form1()
        {
            from = new MailAddress("testprogramcsharp@gmail.com", "Daniil"); // отправитель
            to = new MailAddress("danik1708@ukr.net"); // получатель
            mailMessage = new MailMessage(from, to); // создаем сообщение
            mailMessage.Subject = "Test"; // тема сообщения
            mailMessage.Body = "<h2>Письмо-тест работы smtp-клиента</h2>"; // тело сообщения
            mailMessage.IsBodyHtml = true; // письмо в виде html
            smtp = new SmtpClient("smtp.gmail.com", 587); // создаем клиента для отправки сообщений
            smtp.Credentials = new NetworkCredential("testprogramcsharp@gmail.com", "123456"); // присваиваем логин и пароль
            smtp.EnableSsl = true; // включаем протокол ssl
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            smtp.Send(mailMessage); // отправляем сообщение
        }
    }
}