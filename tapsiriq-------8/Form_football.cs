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
    public partial class Form_football : Form
    {
        
        public string lazimli { get; set; }
        public List<PlayerUC> playerss { get; set; }
        public Form_football()
        {
            InitializeComponent();
        }
        public Form_football(string a)
        {
            InitializeComponent();
            lazimli = a;
        }
        List<FormUC> forms = new List<FormUC>();
        private void button1_Click(object sender, EventArgs e)
        {
             DialogResult = DialogResult.OK; 
        }

        private void Form_football_Load(object sender, EventArgs e)
        {


            int one = int.Parse(lazimli[4].ToString());
            int two = int.Parse(lazimli[2].ToString());
            int three = int.Parse(lazimli[0].ToString());
            int sahe = 700;
            int index =sahe/ (int.Parse(lazimli[4].ToString())+1);


            for (int i = 0; i < one; i++)
            { 
                
                FormUC import = new FormUC();
                if (playerss[i].radioButton1.Checked == true)
                {
                    import.pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\tapsiriq-------8\tapsiriq-------8\Resources\Без названия (2).png");
                }
                import.label1.BackColor = Color.Transparent;

                
                import.Location = new Point(250 + index,530);
                //import.Dock= DockStyle.Left;
                Controls.Add(import);
                import.label1.Text = playerss[i].textBox3.Text;
                import.label2.Text = playerss[i].textBox2.Text;
                index += sahe / (int.Parse(lazimli[4].ToString()));
                forms.Add(import);
            }

            index = sahe / (int.Parse(lazimli[2].ToString() )+1);
            for (int i = one; i < two+one; i++)
            {
                FormUC import = new FormUC();
                import.label1.BackColor = Color.Transparent;
                if (playerss[i].radioButton1.Checked == true)
                {
                    import.pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\tapsiriq-------8\tapsiriq-------8\Resources\Без названия (2).png");
                }
                import.Location = new Point(250+index, 350);
                import.label1.Text = playerss[i].textBox3.Text;
                import.label2.Text = playerss[i].textBox2.Text;
                Controls.Add(import);
                index += sahe / (int.Parse(lazimli[2].ToString()));
                forms.Add(import);

            }
            index = sahe / (int.Parse(lazimli[0].ToString())+1);
            for (int i = one+ two; i < three+one+two; i++)
            {
                FormUC import = new FormUC();
                import.label1.BackColor = Color.Transparent;
                if (playerss[i].radioButton1.Checked == true)
                {
                    import.pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\User\source\repos\tapsiriq-------8\tapsiriq-------8\Resources\Без названия (2).png");
                }
                import.Location = new Point(250 + index, 150);
                import.label1.Text = playerss[i].textBox3.Text;
                import.label2.Text = playerss[i].textBox2.Text;
                Controls.Add(import);
                index += sahe / (int.Parse(lazimli[0].ToString()));
                forms.Add(import);

            }
         
        }
    }
}
