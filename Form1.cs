using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
namespace compilador1
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            codigos.Select();

        }

        int tokenllevado = 0;

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            // Guardar archivo de texto
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "documento de texto|*.txt";
            guardar.Title = "GUARDAR";
            guardar.FileName = "Sin titulo";


            var resultado = guardar.ShowDialog();
            if (resultado == DialogResult.OK) {
                StreamWriter escribir = new StreamWriter(guardar.FileName);
                foreach (object line in codigos.Lines) {
                    escribir.WriteLine(line);
                }
                escribir.Close();
            }
        }

        private void AbrirButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "documento de texto|*.txt";
            abrir.Title = "Abrir";
            abrir.FileName = "Sin titulo";
            var resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(abrir.FileName);
                codigos.Text = leer.ReadToEnd();

                leer.Close();
            }


        }

        private void compi(string cadena)
        {

            int inicioestado;
            char cadenaconcatenar;
            string token1 = "";
            dataLexemas.Rows.Clear();

            for (inicioestado = 0; inicioestado < cadena.Length; inicioestado++)
            {
                cadenaconcatenar = cadena[inicioestado];

                token1 += cadenaconcatenar;
                Boolean gg = false;


                if (token1 == "Texto" |
                    token1 == "texto" |
                    token1 == "Numero" |
                    token1 == "numero" |
                    token1 == "Booleano" |
                    token1 == "booleano" |
                    token1 == "Igual" |
                    token1 == "igual" |
                    token1 == "Mas" |
                    token1 == "mas" |
                    token1 == "Menos" |
                    token1 == "menos" |
                    token1 == "Multiplica" |
                    token1 == "multiplica" |
                    token1 == "Divide" |
                    token1 == "divide" |
                    token1 == "Diferente" |
                    token1 == "diferente" |
                    token1 == "Menor o igual" |
                    token1 == "menor o igual" |
                    token1 == "Mayor o igual" |
                    token1 == "mayor o igual" | 
                    token1 == "Lo mismo" |
                    token1 == "lo mismo" |
                    token1 == "Y" |
                    token1 == "y" |
                    token1 == "O" |
                    token1 == "o" |
                    token1 == "Si" |
                    token1 == "si" |
                    token1 == "Mientras" |
                    token1 == "mientras" |
                    token1 == "Cambio" |
                    token1 == "Cambio" |
                    token1 == "Caso" |
                    token1 == "Caso" |
                    token1 == "Repetir" |
                    token1 == "repetir" |
                    token1 == "Regresa" |
                    token1 == "Regresa" |
                    token1 == "Leer" |
                    token1 == "Leer" |
                    token1 == "Mostrar" |
                    token1 == "mostrar" |
                    token1 == "Espera" |
                    token1 == "espera" |
                    token1 == "Limpia" |
                    token1 == "limpia" |
                    token1 == "Detener" |
                    token1 == "Detener"
                    )
                {
                    DescripciondelosToken(token1);
                    TokenValidos(token1);
                    token1 = "";
                    gg = true;

                }
            }





        }

        public void DescripciondelosToken(string tokeniguala)
        {
            switch (tokeniguala)
            {
                case "Texto":
                    txtSalida.Text = txtSalida.Text + "Texto" + " " + "Palabra reservada (para cadenas de texto)\n";
                    break;
                case "texto":
                    txtSalida.Text = txtSalida.Text + "texto " + "Palabra reservada (para cadenas de texto)\n";
                    break;
                case "Numero":
                    txtSalida.Text = txtSalida.Text + "Numero" + " " + "Palabra reservada (para numeros enteros)\n";
                    break;
                case "numero":
                    txtSalida.Text = txtSalida.Text + "numero" + " " + "Palabra reservada (para numeros enteros)\n";
                    break;
                case "Booleano":
                    txtSalida.Text = txtSalida.Text + "Booleano" + " " + "Palabra reservada True o False \n";
                    break;
                case "booleano":
                    txtSalida.Text = txtSalida.Text + "booleano" + " " + "Palabra reservada True o False\n";
                    break;
                case "Igual":
                    txtSalida.Text = txtSalida.Text + "Igual" + " " + "Palabra reservada para asignacion\n";
                    break;
                case "igual":
                    txtSalida.Text = txtSalida.Text + "igual" + " " + "Palabra reservada para asignacion\n";
                    break;
                case "Mayor o igual":
                    txtSalida.Text = txtSalida.Text + "Mayor o igual" + " " + "Palabra reservada para comparacion\n";
                    break;
                case "mayor o igual":
                    txtSalida.Text = txtSalida.Text + "mayor o igual" + " " + "Palabra reservada para comparacion\n";
                    break;
                case "Menor o igual":
                    txtSalida.Text = txtSalida.Text + "Menor o igual" + " " + "Palabra reservada para comparacion\n";
                    break;
                case "menor o igual":
                    txtSalida.Text = txtSalida.Text + "menor o igual" + " " + "Palabra reservada para comparacion\n";
                    break;
                case "Diferente":
                    txtSalida.Text = txtSalida.Text + "Diferente" + " " + "Palabra reservada para diferente\n";
                    break;
                case "diferente":
                    txtSalida.Text = txtSalida.Text + "diferente" + " " + "Palabra reservada para diferente\n";
                    break;
                case "(":
                    txtSalida.Text = txtSalida.Text + "*(*" + " " + "Signo Apertura - parentesis\n";
                    break;
                case " ":
                    txtSalida.Text = txtSalida.Text + "(espacio)" + " " + "Espacio sin texto\n";
                    break;
                case ")":
                    txtSalida.Text = txtSalida.Text + "*)*" + " " + "Signo Cierre - parentesis\n";
                    break;
                case "Mas":
                    txtSalida.Text = txtSalida.Text + "Mas" + " " + "Palabra reservada para sumar\n";
                    break;
                case "mas":
                    txtSalida.Text = txtSalida.Text + "mas" + " " + "Palabra reservada para sumar\n";
                    break;
                case ";":
                    txtSalida.Text = txtSalida.Text + ";" + " " + "Signo\n";
                    break;
                case "Menos":
                    txtSalida.Text = txtSalida.Text + "Menos" + " " + "Palabra reservada para restar\n";
                    break;
                case "menos":
                    txtSalida.Text = txtSalida.Text + "menos" + " " + "Palabra reservada para restar\n";
                    break;
                case "Divide":
                    txtSalida.Text = txtSalida.Text + "Divide" + " " + "Palabra reservada para dividir\n";
                    break;
                case "divide":
                    txtSalida.Text = txtSalida.Text + "divide" + " " + "Palabra reservada para dividir\n";
                    break;
                case "Repetir":
                    txtSalida.Text = txtSalida.Text + "Repetir" + " " + "Palara reservada For\n";
                    break;
                case "repetir":
                    txtSalida.Text = txtSalida.Text + "repetir" + " " + "Palabra reservada For\n";
                    break;
                case "Mientras":
                    txtSalida.Text = txtSalida.Text + "Mientras" + " " + "Instruccion While\n";
                    break;
                case "mientras":
                    txtSalida.Text = txtSalida.Text + "mientras" + " " + "Instruccion While\n";
                    break;
                case "Cambio":
                    txtSalida.Text = txtSalida.Text + "Cambio" + " " + "Instruccion Switch\n";
                    break;
                case "cambio":
                    txtSalida.Text = txtSalida.Text + "cambio" + " " + "Instruccion Switch\n";
                    break;
                case "Caso":
                    txtSalida.Text = txtSalida.Text + "Cambio" + " " + "Instruccion Case\n";
                    break;
                case "caso":
                    txtSalida.Text = txtSalida.Text + "cambio" + " " + "Instruccion Case\n";
                    break;
                case "Y":
                    txtSalida.Text = txtSalida.Text + "Y" + " " + "Instruccion IF\n";
                    break;
                case "y":
                    txtSalida.Text = txtSalida.Text + "y" + " " + "Instruccion IF\n";
                    break;
                case "O":
                    txtSalida.Text = txtSalida.Text + "O" + " " + "Instruccion OR\n";
                    break;
                case "o":
                    txtSalida.Text = txtSalida.Text + "o" + " " + "Instruccion OR\n";
                    break;
                case "Regresa":
                    txtSalida.Text = txtSalida.Text + "Regresa" + " " + "Instruccion Return\n";
                    break;
                case "regresa":
                    txtSalida.Text = txtSalida.Text + "regresa" + " " + "Instruccion Return\n";
                    break;
                case "Leer":
                    txtSalida.Text = txtSalida.Text + "leer" + " " + "Instruccion Getch\n";
                    break;
                case "leer":
                    txtSalida.Text = txtSalida.Text + "leer" + " " + "Instruccion Getch\n";
                    break;
                case "Espera":
                    txtSalida.Text = txtSalida.Text + "Espera" + " " + "Instruccion Delay\n";
                    break;
                case "espera":
                    txtSalida.Text = txtSalida.Text + "espera" + " " + "Instruccion Delay\n";
                    break;
                case "Limpiar":
                    txtSalida.Text = txtSalida.Text + "Limpiar" + " " + "Instruccion Clear Screen\n";
                    break;
                case "limpiar":
                    txtSalida.Text = txtSalida.Text + "limpiar" + " " + "Instruccion Clear Screen\n";
                    break;
                case "Detener":
                    txtSalida.Text = txtSalida.Text + "Detener" + " " + "Instruccion Break\n";
                    break;
                case "detener":
                    txtSalida.Text = txtSalida.Text + "detener" + " " + "Instruccion Break\n";
                    break;

            }

        }
    
        private void TokenValidos(string lexema)
        {
            tokenllevado = dataLexemas.Rows.Add();
            switch (lexema)
            {
                case "Texto":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "texto":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Numero":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "numero":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Booleano":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "booleano":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;    
                case "Igual":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "igual":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Mas":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "mas":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Menos":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "menos":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Multiplica":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "multiplica":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Divide":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "divide":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;  
                case "Diferente":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "diferente":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;     
                case "Menor o igual":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "menor o igual":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;     
                case "Mayor o igual":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "mayor o igual":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Lo mismo":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "lo mismo":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Y":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "y":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "O":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "o":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "(":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Signo Reservado";
                    break;
                case ")":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Signo Reservado";
                    break;
                case " ":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "espacio en blanco";
                    break;
                case ";":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Signo Reservado";
                    break;
                case "\n":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "salto de linea";
                    break;
                case "Mostrar":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "imprimir en pantalla";
                    break;
                case "mostrar":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "imprimir en pantalla";
                    break;
                case "inicio":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Si":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "si":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Repetir":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "palabra reservada";
                    break;
                case "repetir":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "palabra reservada";
                    break;
                case "mientras":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "palabra reservada";
                    break;
                case "Mientras":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "palabra reservada";
                    break;
                case "Cambio":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "cambio":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Caso":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "palabra reservada";
                    break;
                case "caso":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "palabra reservada";
                    break;
                case "Regresa":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "regresa":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break; 
                case "Leer":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "leer":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Limpiar":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "limpiar":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Detener":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "detener":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                default:
                    break;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
           DialogResult res = MessageBox.Show("Estas seguro que deseas borrar el contenido?", "Alerta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (res== DialogResult.Yes) {

                txtSalida.Text = "";
                dataLexemas.Rows.Clear();
                codigos.Text = "";

            }



           
        }

        private void CompilarButton_Click(object sender, EventArgs e)
        {
            
            string cadenatoken = codigos.Text;      
            compi(cadenatoken);    
            dataLexemas.Visible = true;
           
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            String filename = "CompileText.txt";
            OpenFileDialog abrir = new OpenFileDialog();
            StreamReader leer = new StreamReader(filename);
            codigos.Text = leer.ReadToEnd();


            leer.Close();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Form2 fo = new Form2();
            fo.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            

            
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
           
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
