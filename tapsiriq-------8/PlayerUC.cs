using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tapsiriq_______8
{
    public partial class PlayerUC : UserControl
    {
        public List<PlayerUC> playerss { get; set; }
        public string[] numberss { get; set; }
        public PlayerUC()
        {
            InitializeComponent();
           
        }
        public PlayerUC(List<PlayerUC> players)
        {
            InitializeComponent();
            playerss = players;
        }
        private void PlayerUC_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(playerss.FindAll(player => player.radioButton1.Checked == true).Count>1)
            {
                radioButton1.Checked = false;   
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text)){
                for (int i = 0; i < numberss.Length; i++)
                {
                    if (numberss[i] == textBox2.Text || int.Parse(textBox2.Text) > 99 || int.Parse(textBox2.Text) < 1)
                    {
                        textBox2.Text = null;
                        return;
                    }
                }
                numberss[int.Parse(label1.Text) - 1] = (textBox2.Text);
            }
            
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PlayerUC_Validated(object sender, EventArgs e)
        {
           
            
        }
    }
}
