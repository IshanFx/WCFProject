using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using InstituteAdminSide.InstituteService;

namespace InstituteAdminSide
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void dataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTo.Text = dataList.Items[dataList.FocusedItem.Index].SubItems[2].Text;
        }


        private void rbnTeacher_Click(object sender, EventArgs e)
        {
           

            TeacherServicesClient client = new TeacherServicesClient();
            DataSet set = client.GetTeacherData();
            DataTable table = set.Tables[0];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                ListViewItem list = new ListViewItem(table.Rows[i][0].ToString());
                list.SubItems.Add(table.Rows[i][1] + " " + table.Rows[i][2]);
                list.SubItems.Add(table.Rows[i][6].ToString());
                dataList.Items.Add(list);
            }



        }

        private void chkAllMail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllMail.Checked)
            {
                txtTo.Enabled = false;

            }
            if (chkAllMail.Checked.Equals(false))
            {
                txtTo.Enabled = true;
            }
        }

        private void Send_click(object sender, EventArgs e)
        {
            var mail = new MailMessage();
             try
            {
               
                var client = new SmtpClient("smtpcorp.com", 2525)
                {
                    Credentials = new NetworkCredential("ishantuf@gmail.com", "nvidiagtx680"),
                    EnableSsl = true
                };

                mail.From = new MailAddress("info@ACME.com", "ACME");
                if (!chkAllMail.Checked)
                {
                    mail.To.Add(txtTo.Text);
                    mail.Subject = txtTopic.Text;
                    mail.Body = txtMessage.Text;
                    client.Send(mail);
                }
                else
                {
                    foreach (var copy in GetAllMailAddress())
                    {
                        mail.Bcc.Add(copy.ToString());
                        mail.Subject = txtTopic.Text;
                        mail.Body = txtMessage.Text;
                        client.Send(mail);
                        mail.Bcc.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail Not Send.Try Again Later", "Mail Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                mail.Dispose();
            }     
        }


        private ArrayList GetAllMailAddress()
        {
           
            MailAddress address = null;
            ListViewItem.ListViewSubItem listItems = null;
            ArrayList list = new ArrayList();
            
            for (int i = 0; i < dataList.Items.Count; i++)
            {
                listItems = dataList.Items[i].SubItems[2];
                list.Add(listItems.Text);

            }

            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MailAddress address = null;
            ListViewItem.ListViewSubItem listItems = null;
            ArrayList list = new ArrayList();
            
            for (int i = 0; i < dataList.Items.Count; i++)
            {
                listItems = dataList.Items[i].SubItems[2];
                list.Add(listItems.Text);

            }
            foreach (var items in list)
            {
                MessageBox.Show(items.ToString());
            }
        }
    }
}
