namespace FormularioFB1
{   public partial class Form1 : Form
    { public Form1()
        {
            InitializeComponent();
            //Inicializo la imagen introducida a false para controlar luego cu�ndo aparece
            pictureBox1.Visible = false;
        }private void textBox1_TextChanged(object sender, EventArgs e)
        {   //Cuando se empiece a escribir en la primera caja la etiqueta Nombre se cambiar� por 
            //completado
            label1.Text = "Completado";
        }
        private void button1_Click(object sender, EventArgs e)
        {//Cuando se pulse el bot�n cambiar� el contenido de su texto
            button1.Text = "Cliente registrado";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Meto un condicional para mostrar una imagen en caso de que est� "checkada" la caja
            if (checkBox1.Checked) { pictureBox1.Visible = true; }
            //Otro condicional para probar m�s funciones
            if (checkBox1.Checked)
            {//si est� activada la caja cambiar� el texto del CheckBox y su color de fondo
                checkBox1.Text = "De toda la vida";
                checkBox1.BackColor = Color.LightGreen;
            } else {//se desactivar�n las funciones anteriores cuando se desactive la caja
                checkBox1.Text = "no es  de siempre";
                checkBox1.BackColor = Color.White;
                //y tambi�n quitamos la imagen en este caso
                pictureBox1.Visible= false;
                    }
        }
    }
}
