using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] splitString = txtInput.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            foreach (var item in splitString)
            {

                string[] result = item.Split(new char[]{ ' '}, StringSplitOptions.RemoveEmptyEntries);
                List<string> endResult = new List<string>();
                foreach (var r in result)
                {
                    char[] tmps = r.ToArray();
                    tmps[0] = char.Parse(tmps[0].ToString().ToUpper());
                    string er = string.Join("", tmps).Replace("-", "");
                    endResult.Add(er);
                }
                sb.AppendLine(string.Join("", endResult));
            }
            txtOutPut.Text = sb.ToString();
        }
    }
}
