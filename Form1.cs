using System;
using System.ComponentModel;
using System.Collections.Concurrent;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendWhatsAppMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void sendWhatsApp(string number, string message)
        {
            try
            {
                if (number == "")
                {
                    MessageBox.Show("Numara Eklenmedi");
                }
                if (number.Length <= 0)
                {
                    number = "+90" + number;
                }
                number = number.Replace(" ", "");
                System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=" + number + "&text=" + message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendWhatsApp(txtNumber.Text, txtMessage.Text);
        }
        public void clearTextbox()
        {
            txtMessage.Text = "";
            txtNumber.Text = "";
        }
    }
}
