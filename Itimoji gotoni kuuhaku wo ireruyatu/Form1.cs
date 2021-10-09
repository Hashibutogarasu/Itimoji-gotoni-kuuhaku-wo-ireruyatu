using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itimoji_gotoni_kuuhaku_wo_ireruyatu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void Changer()
        {
            CountLabel.Text = HenkansurumojiBox.Text.Length.ToString();
            CountLineLabel.Text = HenkansurumojiBox.Lines.Length.ToString();

            string inputtext = HenkansurumojiBox.Text;
            string input2 = ItimojigotoniirerumojiBox.Text;

            if (input2.Length == 0)
            {
                input2 = "";
            }

            string output = "";

            foreach (char c in inputtext)
            {
                output += c.ToString() + input2;
            }

            OutputBox.Text = output.TrimEnd().TrimStart();

            await Task.Delay(100);
        }

        private void HenkansurumojiBox_TextChanged(object sender, EventArgs e)
        {
            Changer();
        }

        private void ItimojigotoniirerumojiBox_TextChanged(object sender, EventArgs e)
        {
            Changer();
        }
    }
}