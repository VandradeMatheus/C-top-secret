using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste001
{
    delegate void FileFound(string path);

    internal class Buscador
    {

        private string termo;
        private string dir;

        public event FileFound OnFileFound;

        public Buscador(string dir, string termo)
        {
            this.dir = dir;
            this.termo = termo;
        }

        private void Scan(string dir)
        {

            string[] files = Directory.GetFiles(dir);
            string[] dirs = Directory.GetDirectories(dir);

            List<string> allfiles = new List<string>();
            allfiles.AddRange(files);
            allfiles.AddRange(dirs);

            foreach (string s in allfiles)
            {
                string _s = s.ToLower();
                string _term = this.termo.ToLower();

                if (Directory.Exists(_s) && s!="." && s!="..") 
                {
                    Scan(s);
                    continue;
                }

                ///Comentário do cara
                
                if (_s.Contains(_term))
                {
                    OnFileFound(s);
                }
            }

        }

        public void Busca()
        {
            Scan(this.dir);
        }

        public string Termo
        {
            set { termo = value; }
            get { return termo; }
        }

        public string Dir
        {
            set { dir = value; }
            get { return dir; }
        }
    }
}
