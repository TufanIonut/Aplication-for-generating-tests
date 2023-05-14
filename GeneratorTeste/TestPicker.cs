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
    public partial class TestPicker : Form
    {
        public static string passingstring;
        public static string passingstring2;
        public TestPicker()
        {
            InitializeComponent();
        
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            passingstring = comboBox1.Text;
            passingstring2 = comboBox2.Text;
            this.Hide();
            Test t = new Test();
            t.ShowDialog();
            this.Close();

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
