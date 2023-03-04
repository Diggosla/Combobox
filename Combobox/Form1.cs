using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class numero : Form
    {
        public numero()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonnumero_Click(object sender, EventArgs e)
        {
            switch( Convert.ToInt32(comboescolha.SelectedItem))
            {
                case 1 :
                    labelresposta.Text = "O més 1 é equivalente a janeiro";
                    break;

                    case 2 :
                    labelresposta.Text = "O mêS 2 é equivalente a Fevareiro";
                    break;

                    case 3 :
                    labelresposta.Text = " O mês 3 é equivalente a Março";
                    break;

                    case 4 :
                    labelresposta.Text = "O Mês 4 é equivalente a Abril";
                    break;

                    case 5 :
                    labelresposta.Text = "O Mês 5 é equivalente a Maio";
                    break;

                    case 6 :
                    labelresposta.Text = "O Mês 6 é equivalente a Junho ";
                    break;

                    case 7 :
                    labelresposta.Text = "O Mês 7 é equivalente a Julho ";
                    break;

                    case 8 :
                    labelresposta.Text = "O Mês 8 é equivalente a  Agosto";
                    break;

                case 9:
                    labelresposta.Text = "O Mês 9 é equivalente a Setembro";
                    break;

                    case 10 :
                    labelresposta.Text = "O Mês 10 é equivalente a  Outubro";
                    break;

                    case 11 :
                    labelresposta.Text = "O Mês 11 é equivalente a Novembro ";
                    break;

                    case 12 :
                    labelresposta.Text = " O Mês" + comboescolha.Text +"  é equivalente a Dezembro ";
                    break;

                    default:
                    labelresposta.Text = " escolha um nuemro porfavor";
                    break;


            }
        }

        private void comboescolha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
