using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        string archivo;
        string[] parts;
        Boolean encontrado = false;

        public Form1()
        {
            InitializeComponent();
        }

        //Método click que abre explorador de archivos para seleccionar uno, comprueba si el archivo es jsn o json
        private void button_Examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();

            if (buscar.ShowDialog() == DialogResult.OK)//Si hemos escojido una dirección
            {
                textBox1.Text = buscar.FileName; //Asignamos al textbox el archivo elejido

                //Para comprobar que el archivo es un .jsn o un .json
                archivo = textBox1.Text;
                parts = archivo.Split('.');
                string word1 = parts[0];
                string word2 = parts[1];

                // El código asignara al booleano semaforo true solo si el archivo es el correcto
                if (word2 == "jsn" || word2 == "json")
                {
                    encontrado = true;
                }
            }
        }

        //Método para abrir el archivo si es que existe y leer y mostrar campos concretos si es un JSON
        private void button_Abrir_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text))//Si el fichero del textbox existe
            {
                Process proceso = Process.Start(textBox1.Text);
                if (encontrado)
                {
                    LeerArchivoJson(textBox1.Text);//Leeremos el archivo json o jsn pasando por parametro 
                                                    //lo que tengamos almacenado en el textBox1.Text
                    encontrado = false;             
                }
            }else
            {
                MessageBox.Show("Introduce un archivo válido!");
            }
        }

        //Método para salir de la aplicación
        private void button_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Para salir de la app
        }

        //Leer archivo JSON y mostrar ventana emergente con valores en campos concretos
        public static void LeerArchivoJson(string filePath)
        {
            // Lee todo el contenido del archivo JSON
            string json = File.ReadAllText(filePath);

            // Analizar el JSON en un objeto JObject
            JObject jsonObj = JObject.Parse(json);

            // Utiliza LINQ para obtener un valor específico del JSON
            var valor1 = jsonObj.Root["OperatorName"];
            var valor2 = jsonObj.Root["ChannelOrder"]?[15];
            var valor3 = jsonObj.Root["GeneralGain"];
            var valor4 = jsonObj.Root["NumLanguages"];

            // Imprime el valor obtenido en ventana emergente
            string mensaje = "";

            if (!string.IsNullOrEmpty(valor1?.ToString()))
            {
               mensaje+="El nombre del operador es: " + valor1+"\n\n";
            }else
            {
                mensaje += "La ruta : Root-OperatorName no existe en el archivo\n\n";
            }

            if (!string.IsNullOrEmpty(valor2?.ToString()))
            {
                mensaje += "El último canal en el orden de los canales es: " + valor2+"\n\n";
            }else
            {
                mensaje += "La ruta : Root-ChannelOrder no existe en el archivo\n\n";
            }

            if (!string.IsNullOrEmpty(valor3?.ToString()))
            {
                mensaje += "La ganancia general del operador es: " + valor3+"\n\n";
            }else
            {
                mensaje += "La ruta : Root-GeneralGain no existe en el archivo\n\n";
            }

            if (!string.IsNullOrEmpty(valor4?.ToString()))
            {
                mensaje += "El numero de idiomas del operador es de: " + valor4;
            }else
            {
                mensaje += "La ruta : Root-NumLanguagues no existe en el archivo ";
            }

            MessageBox.Show(mensaje, "Valores de campos", MessageBoxButtons.OK);
        }
    }
}
