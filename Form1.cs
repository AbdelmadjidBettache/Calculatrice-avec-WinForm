using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculer_Click(object sender, EventArgs e)
        {
            int oprde1 = int.Parse(txt_operande1.Text);
            int oprde2 = int.Parse(txt_operande2.Text);
            char oper = char.Parse(txt_operation.Text);
            int resu = 0;
            //do {
            //    MessageBox.Show("Operation Invalide");

            //} while (oper != '+' || oper != '-' || oper != '*' || oper != '/');
            if (oper == '+')
            {
                resu = oprde1 + oprde2;
                MessageBox.Show("Le Resultat de l'addition est : ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(resu.ToString());
            }
            if (oper == '-')
            {
                resu = oprde1 - oprde2;
                MessageBox.Show("Le Resultat de la soustraction est ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(resu.ToString());
            }
            if (oper == '*')
            {
                resu = oprde1 * oprde2;
                MessageBox.Show("Le Resultat de la multiplication est ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(resu.ToString());
            }
            if (oper == '/')
            {
                if (oprde2 == 0)
                {
                    MessageBox.Show("Impossible de faire la devission sur Zéro");
                }
                resu = oprde1 / oprde2;
                MessageBox.Show("Le Resultat de la devision est ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(resu.ToString());
            }
            
            txt_operande1.Focus();
        }

        private void btn_recommencer_Click(object sender, EventArgs e)
        {
            DialogResult reponse =
            MessageBox.Show("Voulez-vous Recommencer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reponse == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}
