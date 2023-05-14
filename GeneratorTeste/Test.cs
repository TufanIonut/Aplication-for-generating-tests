using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorTeste
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            label1.Text = Login.passingstring3;
            label2.Text = TestPicker.passingstring;
            label3.Text = TestPicker.passingstring2;
            using (testeEntities db = new testeEntities())
            {
                foreach (var item in db.t_Questions)
                {
                    label4.Text = item.Phrase;
                    raspuns1.Text = item.t_Answers.t_textAnswers.TextAnswer;
                    raspuns2.Text = item.t_Answers.t_textAnswers.TextAnswer;
                    raspuns3.Text = item.t_Answers.t_textAnswers.TextAnswer;
                    raspuns4.Text = item.t_Answers.t_textAnswers.TextAnswer;

                    break;
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Label4_Click(object sender, EventArgs e)
        {
        
        }
    }
}
