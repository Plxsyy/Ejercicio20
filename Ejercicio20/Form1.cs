using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMasPackHambuguesa_Click(object sender, EventArgs e)
        {
            int valorActualHamburguesa = int.Parse(numericUpDownHamburguesa.Text);
            int valorActualPapas = int.Parse(numericUpDownPapas.Text);
            int valorActualRefresco = int.Parse(numericUpDownRefresco.Text);
            valorActualHamburguesa++;
            valorActualPapas++;
            valorActualRefresco++;
            numericUpDownHamburguesa.Text = valorActualHamburguesa.ToString();
            numericUpDownPapas.Text = valorActualPapas.ToString();
            numericUpDownRefresco.Text = valorActualRefresco.ToString();


        }

        private void buttonMenosPackHambuguesa_Click(object sender, EventArgs e)
        {
            int valorActualHamburguesa = int.Parse(numericUpDownHamburguesa.Text);
            int valorActualPapas = int.Parse(numericUpDownPapas.Text);
            int valorActualRefresco = int.Parse(numericUpDownRefresco.Text);
            valorActualHamburguesa--;
            valorActualPapas--;
            valorActualRefresco--;
            numericUpDownHamburguesa.Text = valorActualHamburguesa.ToString();
            numericUpDownPapas.Text = valorActualPapas.ToString();
            numericUpDownRefresco.Text = valorActualRefresco.ToString();
        }

        private void buttonMasPackPizza_Click(object sender, EventArgs e)
        {
            int valorActualPizza = int.Parse(numericUpDowPizza.Text);
            int valorActualNugget = int.Parse(numericUpDownNugget.Text);
            int valorActualRefresco = int.Parse(numericUpDownRefresco.Text);
            valorActualPizza++;
            valorActualNugget++;
            valorActualRefresco++;
            numericUpDowPizza.Text = valorActualPizza.ToString();
            numericUpDownNugget.Text = valorActualNugget.ToString();
            numericUpDownRefresco.Text = valorActualRefresco.ToString();
        }

        private void buttonMenosPackPizza_Click(object sender, EventArgs e)
        {
            int valorActualPizza = int.Parse(numericUpDowPizza.Text);
            int valorActualNugget = int.Parse(numericUpDownNugget.Text);
            int valorActualRefresco = int.Parse(numericUpDownRefresco.Text);
            valorActualPizza--;
            valorActualNugget--;
            valorActualRefresco--;
            numericUpDowPizza.Text = valorActualPizza.ToString();
            numericUpDownNugget.Text = valorActualNugget.ToString();
            numericUpDownRefresco.Text = valorActualRefresco.ToString();
        }

        private void buttonMasPackEnsalada_Click(object sender, EventArgs e)
        {
            int valorActualEnsalada = int.Parse(numericUpDownEnsalada.Text);
            int valorActualYogur = int.Parse(numericUpDownYogur.Text);
            int valorActualAgua = int.Parse(numericUpDownAgua.Text);
            valorActualAgua++;
            valorActualEnsalada++;
            valorActualYogur++;
            numericUpDownEnsalada.Text = valorActualEnsalada.ToString();
            numericUpDownYogur.Text = valorActualYogur.ToString();
            numericUpDownAgua.Text = valorActualAgua.ToString();
        }

        private void buttonMenosPackEnsalada_Click(object sender, EventArgs e)
        {
            int valorActualEnsalada = int.Parse(numericUpDownEnsalada.Text);
            int valorActualYogur = int.Parse(numericUpDownYogur.Text);
            int valorActualAgua = int.Parse(numericUpDownAgua.Text);
            valorActualAgua--;
            valorActualEnsalada--;
            valorActualYogur--;
            numericUpDownEnsalada.Text = valorActualEnsalada.ToString();
            numericUpDownYogur.Text = valorActualYogur.ToString();
            numericUpDownAgua.Text = valorActualAgua.ToString();
        }
        private void radioButtonHamburguesa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHamburguesa.Checked)
            {
                buttonMasPackHambuguesa.Enabled = true;
                buttonMenosPackHambuguesa.Enabled = true;
            }
            else {
                buttonMasPackHambuguesa.Enabled = false;
                buttonMenosPackHambuguesa.Enabled = false;
            }
        }

        private void radioButtonPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPizza.Checked)
            {
                buttonMasPackPizza.Enabled = true;
                buttonMenosPackPizza.Enabled = true;
            }
            else
            {
                buttonMasPackPizza.Enabled = false;
                buttonMenosPackPizza.Enabled = false;
            }
        }

        private void radioButtonEnsalada_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEnsalada.Checked)
            {
                buttonMasPackEnsalada.Enabled = true;
                buttonMenosPackEnsalada.Enabled = true;
            }
            else
            {
                buttonMasPackEnsalada.Enabled = false;
                buttonMenosPackEnsalada.Enabled = false;
            }
        }
        private void radioButtonOtras_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOtras.Checked)
            {
                numericUpDownHamburguesa.Enabled = true;
                numericUpDownAgua.Enabled = true;
                numericUpDownEnsalada.Enabled = true;
                numericUpDownNugget.Enabled = true;
                numericUpDownPapas.Enabled = true;
                numericUpDownRefresco.Enabled = true;
                numericUpDownYogur.Enabled = true;
                numericUpDowPizza.Enabled = true;
            }
            else {
                numericUpDownHamburguesa.Enabled = false;
                numericUpDownAgua.Enabled = false;
                numericUpDownEnsalada.Enabled = false;
                numericUpDownNugget.Enabled = false;
                numericUpDownPapas.Enabled = false;
                numericUpDownRefresco.Enabled = false;
                numericUpDownYogur.Enabled = false;
                numericUpDowPizza.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDownAgua.Value= 0;
            numericUpDownEnsalada.Value= 0;
            numericUpDownHamburguesa.Value= 0;
            numericUpDownNugget.Value= 0;
            numericUpDownPapas.Value= 0;
            numericUpDownRefresco.Value= 0;
            numericUpDownYogur.Value= 0;
            numericUpDowPizza.Value= 0;

            radioButtonEnsalada.Checked= false;
            radioButtonHamburguesa.Checked= false;
            radioButtonPizza.Checked= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double unidadesAgua =(int)numericUpDownAgua.Value;
            double totalunidadesAgua = unidadesAgua * 1;

            double unidadesPapas = (int)numericUpDownPapas.Value;
            double totalunidadesPapas = unidadesPapas * 1;

            double unidadesRefresco = (int)numericUpDownRefresco.Value;
            double totalunidadesRefresco = unidadesRefresco * 1.50;

            double unidadesPizza = (int)numericUpDowPizza.Value;
            double totalunidadesPizza = unidadesPizza * 8.50;

            double unidadesNugget = (int)numericUpDownNugget.Value;
            double totalunidadesNugget = unidadesNugget * 4.80;

            double unidadesEnsalada = (int)numericUpDownEnsalada.Value;
            double totalunidadesEnsalada = unidadesEnsalada * 4.80;

            double unidadesYogur = (int)numericUpDownYogur.Value;
            double totalunidadesYogur = unidadesYogur * 4.80;




            double subTotal = totalunidadesAgua + totalunidadesPapas + totalunidadesRefresco + totalunidadesPizza + totalunidadesNugget + totalunidadesEnsalada + totalunidadesYogur;
            textBoxSubtotal.Text = subTotal.ToString();

            double iva = (subTotal * 21) / 100;
            textBoxIva.Text= iva.ToString();

            double totalPagar = subTotal + iva;
            textBoxTotalPagar.Text = totalPagar.ToString();

            if (maskedTextBoxCodigoPostal.Text == "")
            {
                MessageBox.Show("Debes rellenar el campo de codigo postal.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double pagar = double.Parse(textBoxTotalPagar.Text);
            double pago = double.Parse(textBoxPago.Text);
            double cambio = pago - pagar;
            textBoxCambio.Text = cambio.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas continuar?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                
            }
            else if (resultado == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
