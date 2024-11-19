using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Norma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pnlE2H1.BackColor = Color.FromArgb(125, Color.OrangeRed);
            pnlE2H2.BackColor = Color.FromArgb(125, Color.OrangeRed);
            pnlE2H3.BackColor = Color.FromArgb(125, Color.OrangeRed);
            pnlE2H41.BackColor = Color.FromArgb(125, Color.OrangeRed);
            pnlE2H42.BackColor = Color.FromArgb(125, Color.OrangeRed);
            pnlE2H5.BackColor = Color.FromArgb(125, Color.OrangeRed);
            pnlE2H6.BackColor = Color.FromArgb(125, Color.OrangeRed);
        }

        private void chlEncendidoApagado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region ESCENARIO_UNO
        private void chlEncendidoApagado_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (lblControles.Text == "Desactivados")
            {
                MessageBox.Show("Los controles no se activaron", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.NewValue = CheckState.Unchecked;
                return;
            }

            switch (e.Index)
            {
                case 0:
                    MostrarOcultar(e, pnlHabitacionUno);
                    break;
                case 1:
                    MostrarOcultar(e, pnlHabitacionDos);
                    break;
                case 2:
                    MostrarOcultar(e, pnlHabitacionTres);
                    break;
                case 3:
                    MostrarOcultar(e, pnlHabitacionCuatroUno);
                    MostrarOcultar(e, pnlHabitacionCuatroDos);
                    break;
                case 4:
                    MostrarOcultar(e, pnlHabitacionCinco);
                    break;
                case 5:
                    MostrarOcultar(e, pnlHabitacionSeis);
                    break;
            }
        }

        public void MostrarOcultar(ItemCheckEventArgs e, Panel oscuro)
        {
            if (e.NewValue == CheckState.Checked)
            {
                oscuro.BackColor = Color.FromArgb(0, Color.Black);
                return;
            }
            oscuro.BackColor = Color.FromArgb(255, Color.Black);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Start();
                return;
            }

            progressBar1.Value = 0;
            lblControles.Text = "Desactivados";
            pnlHabitacionUno.BackColor = Color.FromArgb(255, Color.Black);
            pnlHabitacionDos.BackColor = Color.FromArgb(255, Color.Black);
            pnlHabitacionTres.BackColor = Color.FromArgb(255, Color.Black);
            pnlHabitacionCuatroUno.BackColor = Color.FromArgb(255, Color.Black);
            pnlHabitacionCuatroDos.BackColor = Color.FromArgb(255, Color.Black);
            pnlHabitacionCinco.BackColor = Color.FromArgb(255, Color.Black);
            pnlHabitacionSeis.BackColor = Color.FromArgb(255, Color.Black);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                // Detiene el timer antes de mostrar el mensaje
                timer1.Stop();

                // Actualiza los controles y muestra el mensaje
                lblControles.Text = "Activados";
                MessageBox.Show("Los controles se activaron", "¡Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }


            progressBar1.Enabled = true;
            progressBar1.Value += 4;
        }
        #endregion

        private void panel8_Pain(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (lblControles2.Text == "Desactivados")
            {
                MessageBox.Show("Los controles no se activaron", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.NewValue = CheckState.Unchecked;
                return;
            }

            switch (e.Index)
            {
                case 0:
                    Clima(e, pnlE2H1);
                    break;
                case 1:
                    Clima(e, pnlE2H2);
                    break;
                case 2:
                    Clima(e, pnlE2H3);
                    break;
                case 3:
                    Clima(e, pnlE2H41);
                    Clima(e, pnlE2H42);
                    break;
                case 4:
                    Clima(e, pnlE2H5);
                    break;
                case 5:
                    Clima(e, pnlE2H6);
                    break;
            }
        }

        public void Clima(ItemCheckEventArgs e, Panel oscuro)
        {
            if (e.NewValue == CheckState.Checked)
            {
                oscuro.BackColor = Color.FromArgb(125, Color.BlueViolet);
                return;
            }
            oscuro.BackColor = Color.FromArgb(125, Color.OrangeRed);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                timer2.Start();
                return;
            }

            progressBar2.Value = 0;
            lblControles2.Text = "Desactivados";
            pnlE2H1.BackColor = Color.FromArgb(125, Color.OrangeRed);
            pnlE2H2.BackColor = Color.FromArgb(125, Color.OrangeRed);
            pnlE2H3.BackColor = Color.FromArgb(125, Color.OrangeRed);
            pnlE2H41.BackColor = Color.FromArgb(125, Color.OrangeRed);
            pnlE2H42.BackColor = Color.FromArgb(125, Color.OrangeRed);
            pnlE2H5.BackColor = Color.FromArgb(125, Color.OrangeRed);
            pnlE2H6.BackColor = Color.FromArgb(125, Color.OrangeRed);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value == 100)
            {
                // Detiene el timer antes de mostrar el mensaje
                timer2.Stop();

                // Actualiza los controles y muestra el mensaje
                lblControles2.Text = "Activados";
                MessageBox.Show("Los controles se activaron", "¡Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }


            progressBar2.Enabled = true;
            progressBar2.Value += 4;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
