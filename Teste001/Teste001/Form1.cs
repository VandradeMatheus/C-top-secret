using System.ComponentModel;
using System.Threading.Tasks;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace Teste001
{
    public partial class Form1 : Form
    {

        private Buscador buscador;
        string diretorio2 = "C:\\Users\\Matheus.Andrade\\Desktop\\Teste";

        public Form1()
        {
            InitializeComponent();
            this.buscador = new Buscador(null, null);
            this.buscador.OnFileFound += FileFound;
            bgWorker.DoWork += WorkInBackground;

        }

        private void FileFound(string path)
        {
            listBox1.BeginInvoke((Action)delegate ()
            {
                string ModifiedPath = Path.GetFileName(path);
                listBox1.Items.Add(ModifiedPath);
            });
        }

        public void WorkInBackground(object sender, DoWorkEventArgs args)
        {
            buscador.Busca();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string[] diretorio = Directory.GetFiles(@"C:\Users\Matheus.Andrade\Desktop\Teste");

            //Puxa todo o diretório do código

            /*foreach (string filepath in diretorio)
            {
                listBox1.Items.Add($"{filepath}");
                
            }*/

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            this.buscador.Termo = textBoxTermo.Text;
            this.buscador.Dir = diretorio2;
            bgWorker.RunWorkerAsync();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            /*string selectedItem = listBox1.SelectedItem.ToString();
            string[] diretorio = Directory.GetFiles(@"D:\Teste\Teste1\Teste2");*/
            System.Diagnostics.Process.Start(@"Acrobat.exe", diretorio2);

     
        }
    }
}
