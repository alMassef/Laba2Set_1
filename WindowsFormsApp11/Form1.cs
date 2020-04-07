using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            GoodSet SetF;
            GoodSet SetS;
            GoodSet res;
            int num;

            SetF = new GoodSet(textSetF.Text);
            SetS = new GoodSet(textSetS.Text);
            //num = int.Parse(textSetS.Text);

            switch (cmbOperation.Text)
            {
                case "Объединение":

                    res = SetF + SetS;
                    //textRes.Text = res.MatrixToString();
                    break;
                case "Пересечение":

                    res = SetF * SetS;

                    break;
                case "Разность":

                    res = SetF - SetS;

                    break;
                case "Добавление элемента":

                    num = int.Parse(textSetS.Text);
                    res = SetF + num;

                    break;
                case "Удаление элемента":

                    num = int.Parse(textSetS.Text);
                    res = SetF - num;

                    break;
                default:
                    res = new GoodSet(0);
                    break;
            }

            textRes.Text = res.MatrixToString();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
