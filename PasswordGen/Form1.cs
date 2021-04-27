using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PasswordGen
{
    public partial class main_form : Form
    {
        string gt;
        const string rc1 = "1234567890";
        const string rc2 = "qwertyuiopasdfghjklzxcvbnm";
        const string rc3 = "QWERTYUIOPASDFGHJKLZXCVBNM";
        const string rc4 = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM0123456789";
        const string rc5 = "qwertyuiopasdfghjklzxcvbnm0123456789*#@^&'?!";
        const string sPath = "saved_passwords_";
        DateTime DTN;
        string sTime;
        static readonly Random rndGen = new Random();


        static string GetRandomPassword(string ch, int pwdLength)
        {
            char[] letters = ch.ToCharArray();
            string s = "";
            for (int i = 0; i < pwdLength; i++)
            {
                s += letters[rndGen.Next(letters.Length)].ToString();
            }
            return s;
        }

        public main_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            i = gen_range_bar.Value;

            try
            {               
                result_gen.Text = GetRandomPassword(gt, i);
                pwd_list.Items.Add(result_gen.Text);
            }
            catch
            {
                MessageBox.Show("Надо выбрать тип символов справа", "PasswordGen");
            }            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            gen_range.Text = gen_range_bar.Value.ToString();
        }               

        private void digits_only_Click(object sender, EventArgs e)
        {
            if (digits_only.Checked == true)
            {
                gt = rc1;

                digits_only.Checked = true;
                lowletters_only.Checked = false;
                upletters_only.Checked = false;
                digitsandletters_only.Checked = false;
                digitsletterssymbols.Checked = false;
            }
        }

        private void lowletters_only_Click(object sender, EventArgs e)
        {
            if (lowletters_only.Checked == true)
            {
                gt = rc2;

                digits_only.Checked = false;
                lowletters_only.Checked = true;
                upletters_only.Checked = false;
                digitsandletters_only.Checked = false;
                digitsletterssymbols.Checked = false;
            }
        }

        private void upletters_only_Click(object sender, EventArgs e)
        {
            if (upletters_only.Checked == true)
            {
                gt = rc3;

                digits_only.Checked = false;
                lowletters_only.Checked = false;
                upletters_only.Checked = true;
                digitsandletters_only.Checked = false;
                digitsletterssymbols.Checked = false;
            }
        }

        private void digitsandletters_only_Click(object sender, EventArgs e)
        {
            if (digitsandletters_only.Checked == true)
            {
                gt = rc4;

                digits_only.Checked = false;
                lowletters_only.Checked = false;
                upletters_only.Checked = false;
                digitsandletters_only.Checked = true;
                digitsletterssymbols.Checked = false;
            }
        }

        private void digitsletterssymbols_Click(object sender, EventArgs e)
        {
            if (digitsletterssymbols.Checked == true)
            {
                gt = rc5;

                digits_only.Checked = false;
                lowletters_only.Checked = false;
                upletters_only.Checked = false;
                digitsandletters_only.Checked = false;
                digitsletterssymbols.Checked = true;
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            pwd_list.Items.Clear();
            result_gen.Text = "";
            
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            sTime = DTN.Month.ToString() + "-" + DTN.Day.ToString() + "-" + DTN.Year.ToString() + "-" + DTN.Hour.ToString() + "-" + DTN.Minute.ToString() + "-" + DTN.Second.ToString();
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath+"_"+sTime+".txt");
            foreach (var item in pwd_list.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }

            SaveFile.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DTN = DateTime.Now;
        }
    }
}
