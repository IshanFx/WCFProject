using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using InstituteAdminSide.InstituteService;

namespace InstituteAdminSide
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstituteService.AccountServiceClient accountService = new AccountServiceClient();
            Account account = new Account();
            try
            {
                account.EMail = txtForgetMail.Text;
                DataSet set = accountService.ForgetPassword(account);
                if (set.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Not");
                }
                else
                {
                    var mail = new MailMessage();
                    var client = new SmtpClient("smtpcorp.com", 2525)
                    {
                        Credentials = new NetworkCredential("ishantuf@gmail.com", "nvidiagtx680"),
                        EnableSsl = true
                    };
                    mail.From = new MailAddress("info@ACME.com");
                    mail.To.Add(txtForgetMail.Text);
                    mail.Subject = "Password Lost";

                    var htmlView =
                        AlternateView.CreateAlternateViewFromString(
                            "Username :" + set.Tables[0].Rows[0][0].ToString() + "<br>Password :" +
                            set.Tables[0].Rows[0][1].ToString(), null, "text/html");

                    mail.AlternateViews.Add(htmlView);

                    client.Send(mail);
                    MessageBox.Show("Mail Send success Check Mail Box", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                }
            }
            catch (SmtpFailedRecipientException recipientException)
            {
                MessageBox.Show("Mail not Send", "Not send", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Not send", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        LogIn log;
        private void label1_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            timer1.Start();

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Height <= 150)
            {
                panel1.Height += 5;
            }


        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            panel1.Height = 0;
        }

        private void LogInClick(object sender, EventArgs e)
        {
            InstituteService.AccountServiceClient client = new AccountServiceClient();
            Account account = new Account();
            account.UserName = txtUserName.Text;
            account.Password = txtPassword.Text;
            DataSet set = client.CheckLogIn(account);
            
            if (set.Tables[0].Rows.Count==0)
            {
                MessageBox.Show("Incorrect User Name Password match", "Not Found", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DataTable table = set.Tables[0];
                MessageBox.Show(String.Format("Welcome {0}",table.Rows[0][0]),"Hello User",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Home home = new Home();
                home.Show();
                this.Hide();
            }


        }
    }
}
