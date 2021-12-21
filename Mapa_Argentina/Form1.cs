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
    public partial class Form1 : Form
    {
        Point formPosition;
        Boolean mouseAction;

        public Form1()
        {
            InitializeComponent();
            pic_comenzar.Enabled = false;
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            if (txt_nombre.Text.Trim() != "") {  // Trim() -> le saco los espacios en blanco antes y después del nombre
                pic_comenzar.Enabled = true;
                pic_comenzar.BorderStyle = BorderStyle.None;
                errorProvider1.SetError(txt_nombre, ""); // vacío el mensaje de error del ícono de error
                lbl_mensaje.Visible = false; // vacío lbl_mensaje
            }
            else
            {
                // si txt_nombre está vacío, deshabilito el botón "Comenzar" [si solo pongo espacios, como
                // el Trim() anterior quita los espacios adelante y atrás del nombre, lo toma como vacío]
                pic_comenzar.Enabled = false;
                pic_comenzar.BorderStyle = BorderStyle.Fixed3D;
                errorProvider1.SetError(txt_nombre, "");
                lbl_mensaje.Visible = false;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                lbl_mensaje.Visible = true;
                errorProvider1.SetError(txt_nombre, "Tu nombre no puede contener números ni símbolos"); // muestro el mensaje de error en del ícono de error
            }
            else
            {
                errorProvider1.SetError(txt_nombre, "");
                lbl_mensaje.Visible = false;
            }
        }

        private void pic_instrucciones_Click(object sender, EventArgs e)
        {
            if (lbl_instrucciones.Visible == false)
            {

                lbl_instrucciones.Visible = true;
            }
            else
            {
                lbl_instrucciones.Visible = false;
            }
        }

        private void pic_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_comenzar_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();   // instancio un objeto “f” de tipo Form
            f.lbl_nombre.Text = "Hola " + txt_nombre.Text.Trim();
            f.Show();        // muestra el Form2 al apretar el botón
            this.Hide();    // oculto el Form1 (si fuera this.Close(); cerraría la aplicación)
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            formPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - formPosition.X, Cursor.Position.Y - formPosition.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        
    }
}
