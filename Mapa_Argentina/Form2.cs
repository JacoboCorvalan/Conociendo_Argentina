using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapa_Argentina
{
    public partial class Form2 : Form
    {
        Point formPosition;
        Boolean mouseAction;

        public Form2()
        {
            InitializeComponent();

        }

        private void pic_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_finalizar_Click(object sender, EventArgs e)
        {
            int correctas = 0;
            int incorrectas = 0;

            if (comboBox0.SelectedIndex == 8)
            {
                lbl_jujuy.Visible = true;
                lbl_jujuy2.Visible = false;
                correctas = correctas + 1;

            }
            else
            {
                lbl_jujuy.Visible = false;
                lbl_jujuy2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox1.SelectedIndex == 15)
            {
                lbl_salta.Visible = true;
                lbl_salta2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_salta.Visible = false;
                lbl_salta2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox2.SelectedIndex == 1)
            {
                lbl_catamarca.Visible = true;
                lbl_catamarca2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_catamarca.Visible = false;
                lbl_catamarca2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox3.SelectedIndex == 22)
            {
                lbl_tucuman.Visible = true;
                lbl_tucuman2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_tucuman.Visible = false;
                lbl_tucuman2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox4.SelectedIndex == 20)
            {
                lbl_sgoestero.Visible = true;
                lbl_sgoestero2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_sgoestero.Visible = false;
                lbl_sgoestero2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox5.SelectedIndex == 2)
            {
                lbl_chaco.Visible = true;
                lbl_chaco2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_chaco.Visible = false;
                lbl_chaco2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox6.SelectedIndex == 7)
            {
                lbl_formosa.Visible = true;
                lbl_formosa2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_formosa.Visible = false;
                lbl_formosa2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox7.SelectedIndex == 12)
            {
                lbl_misiones.Visible = true;
                lbl_misiones2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_misiones.Visible = false;
                lbl_misiones2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox8.SelectedIndex == 5)
            {
                lbl_corrientes.Visible = true;
                lbl_corrientes2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_corrientes.Visible = false;
                lbl_corrientes2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox9.SelectedIndex == 19)
            {
                lbl_santafe.Visible = true;
                lbl_santafe2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_santafe.Visible = false;
                lbl_santafe2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox10.SelectedIndex == 4)
            {
                lbl_cordoba.Visible = true;
                lbl_cordoba2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_cordoba.Visible = false;
                lbl_cordoba2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox11.SelectedIndex == 10)
            {
                lbl_larioja.Visible = true;
                lbl_larioja2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_larioja.Visible = false;
                lbl_larioja2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox12.SelectedIndex == 16)
            {
                lbl_sanjuan.Visible = true;
                lbl_sanjuan2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_sanjuan.Visible = false;
                lbl_sanjuan2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox13.SelectedIndex == 11)
            {
                lbl_mendoza.Visible = true;
                lbl_mendoza2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_mendoza.Visible = false;
                lbl_mendoza2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox14.SelectedIndex == 17)
            {
                lbl_sanluis.Visible = true;
                lbl_sanluis2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_sanluis.Visible = false;
                lbl_sanluis2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox15.SelectedIndex == 6)
            {
                lbl_entrerios.Visible = true;
                lbl_entrerios2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_entrerios.Visible = false;
                lbl_entrerios2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox16.SelectedIndex == 0)
            {
                lbl_bsas.Visible = true;
                lbl_bsas2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_bsas.Visible = false;
                lbl_bsas2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox17.SelectedIndex == 9)
            {
                lbl_lapampa.Visible = true;
                lbl_lapampa2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_lapampa.Visible = false;
                lbl_lapampa2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox18.SelectedIndex == 13)
            {
                lbl_neuquen.Visible = true;
                lbl_neuquen2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_neuquen.Visible = false;
                lbl_neuquen2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox19.SelectedIndex == 14)
            {
                lbl_rionegro.Visible = true;
                lbl_rionegro2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_rionegro.Visible = false;
                lbl_rionegro2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox20.SelectedIndex == 3)
            {
                lbl_chubut.Visible = true;
                lbl_chubut2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_chubut.Visible = false;
                lbl_chubut2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox21.SelectedIndex == 18)
            {
                lbl_scruz.Visible = true;
                lbl_scruz2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_scruz.Visible = false;
                lbl_scruz2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            if (comboBox22.SelectedIndex == 21)
            {
                lbl_tf.Visible = true;
                lbl_tf2.Visible = false;
                correctas = correctas + 1;
            }
            else
            {
                lbl_tf.Visible = false;
                lbl_tf2.Visible = true;
                incorrectas = incorrectas + 1;
            }

            //lbl_incorrectas.Visible = true;
            //lbl_correctas.Visible = true;
            lbl_correctas.Text = ("Correctas: " + correctas);
            lbl_incorrectas.Text = ("Incorrectas: " + incorrectas);
            
            pic_reiniciar.Enabled = true;
            pic_reiniciar.BorderStyle = BorderStyle.None;

         }

        private void pic_jugar_Click(object sender, EventArgs e)
        {
            comboBox0.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
            comboBox7.Enabled = true;
            comboBox8.Enabled = true;
            comboBox9.Enabled = true;
            comboBox10.Enabled = true;
            comboBox11.Enabled = true;
            comboBox12.Enabled = true;
            comboBox13.Enabled = true;
            comboBox14.Enabled = true;
            comboBox15.Enabled = true;
            comboBox16.Enabled = true;
            comboBox17.Enabled = true;
            comboBox18.Enabled = true;
            comboBox19.Enabled = true;
            comboBox20.Enabled = true;
            comboBox21.Enabled = true;
            comboBox22.Enabled = true;

            
            pic_jugar.Enabled = false;
            pic_jugar.BorderStyle = BorderStyle.Fixed3D;
            
            pic_reiniciar.Enabled = false;
            pic_reiniciar.BorderStyle = BorderStyle.Fixed3D;
            
            pic_finalizar.Enabled = true;
            pic_finalizar.BorderStyle = BorderStyle.None;
        }

        private void pic_reiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }
    }
}
