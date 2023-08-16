using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontEndNum
{
    public partial class InterfazNumeros : Form

    {
        Numeros numeros = new Numeros();
        public InterfazNumeros()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregarNumeros_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox1.Text, out int num1) ||
                !int.TryParse(textBox2.Text, out int num2) ||
                !int.TryParse(textBox3.Text, out int num3) ||
                !int.TryParse(textBox4.Text, out int num4) ||
                !int.TryParse(textBox5.Text, out int num5))
            {
                MessageBox.Show("Ingrese números enteros válidos en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            numeros.AgregarNumeros(num1);
            numeros.AgregarNumeros(num2);
            numeros.AgregarNumeros(num3);
            numeros.AgregarNumeros(num4);
            numeros.AgregarNumeros(num5);

            numeros.OrdenarNumeros();
            numeros.ObtenerNumerosFaltantes();
            MostrarNumeros();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MostrarNumeros()
        {
            listBoxNumeros.Items.Clear();

            int NumeroMin = numeros.ObtenerNumeros().First.Value;
            int NumeroMax = numeros.ObtenerNumeros().Last.Value;
            int intermedios = (NumeroMax - NumeroMin) / 4;
            listBoxNumeros.Items.Add($"Mínimo: {NumeroMin}");
            for (int i = 1; i <= 3; i++)
            {
                int intermedio = NumeroMin + i * intermedios;
                listBoxNumeros.Items.Add($"Intermedio {i}: {intermedio}");
            }

            listBoxNumeros.Items.Add($"Máximo: {NumeroMax}");          
            foreach (int num in numeros.ObtenerNumeros())
            {
                listBoxNumeros.Items.Add(num);
            }
        }

        private void listBoxNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
