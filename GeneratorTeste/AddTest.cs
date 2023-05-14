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
    public partial class AddTest : Form
    {
        public AddTest()
        {
            InitializeComponent();
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            bool corect = false;
            if (checkBox1.Checked)
            {
                corect = true;
            }
            if (checkBox2.Checked)
            {
                corect = true;
            }
            if (checkBox3.Checked)
            {
                corect = true;

            }
            if (checkBox4.Checked)
            {
                corect = true;
            }


            using (testeEntities test = new testeEntities())
            {
                var Question = new t_Questions
                {
                    Phrase = phrase.Text.Trim(),
                    Points = int.Parse(Points.Text.Trim()),
                    DifficultyLvl = int.Parse(difflvl.Text.Trim())
                };
                var answers1 = new t_textAnswers
                {
                    TextAnswer = ans1.Text.Trim(),
                };
                var answers2 = new t_textAnswers
                {
                    TextAnswer = ans2.Text.Trim(),
                };
                var answers3 = new t_textAnswers
                {
                    TextAnswer = ans1.Text.Trim(),
                };
                var answers4 = new t_textAnswers
                {
                    TextAnswer = ans4.Text.Trim(),
                };
                var correct1 = new t_Answers
                {
                    ItsTrue = corect
                };
                var correct2 = new t_Answers
                {
                    ItsTrue = corect
                };
                var correct3 = new t_Answers
                {
                    ItsTrue = corect
                };
                var correct4 = new t_Answers
                {
                    ItsTrue = corect
                };
                test.t_Questions.Add(Question);
                test.t_textAnswers.Add(answers1);
                test.t_textAnswers.Add(answers2);
                test.t_textAnswers.Add(answers3);
                test.t_textAnswers.Add(answers4);
                test.t_Answers.Add(correct1);
                test.t_Answers.Add(correct2);
                test.t_Answers.Add(correct3);
                test.t_Answers.Add(correct4);
                test.SaveChanges();
            }
        }
    }
}

