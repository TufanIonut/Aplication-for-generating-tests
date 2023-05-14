using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorTeste
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]  
        static void Main()
        {
            Application.Run(new Login());
            //Application.Run(new AddTest());
            //List<string> listPhrase = new List<string>();
            //List<string> listAnsw = new List<string>();
            //List<string> listAnsw2 = new List<string>();
            //List<string> listCorAnsw = new List<string>();
            //List<int> listPoints = new List<int>();
            //using (TesteEntities db=new TesteEntities())
            //{
            //    foreach (var item in db.Questions)
            //    {
            //        listPhrase.Add(item.phrase);
            //        listAnsw.Add(item.answers);
            //        listCorAnsw.Add(item.correct_answers);
            //        listPoints.Add(item.points);
            //    }
            //    foreach (var item in listAnsw)
            //    {
            //        item.Split('/');
            //        listAnsw2.Add(item);

            //    }  /*MessageBox.Show(listAnsw2[0]);*/

        }
        }
    }

