using System.Net;
using System.Net.Mail;

namespace EmailSender
{
    public partial class Form1 : Form
    {
        private MailAddress from;           // �����������
        private MailAddress to;             // ����������
        private MailMessage mailMessage;    // ���������
        private SmtpClient smtp;            // ������ ��� �������� ���������
        
        public Form1()
        {
            from = new MailAddress("testprogramcsharp@gmail.com", "Daniil"); // �����������
            to = new MailAddress("danik1708@ukr.net"); // ����������
            mailMessage = new MailMessage(from, to); // ������� ���������
            mailMessage.Subject = "Test"; // ���� ���������
            mailMessage.Body = "<h2>������-���� ������ smtp-�������</h2>"; // ���� ���������
            mailMessage.IsBodyHtml = true; // ������ � ���� html
            smtp = new SmtpClient("smtp.gmail.com", 587); // ������� ������� ��� �������� ���������
            smtp.Credentials = new NetworkCredential("testprogramcsharp@gmail.com", "123456"); // ����������� ����� � ������
            smtp.EnableSsl = true; // �������� �������� ssl
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            smtp.Send(mailMessage); // ���������� ���������
        }
    }
}