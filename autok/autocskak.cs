using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace autok
{
    class autocskak
    {
        private string _marka;
        private string _modell;
        private int _evjarat;
        private int _kilometer;
        private string _uzemanyag;
        private int _ára;

        void asd()
        {
            using(StreamReader sr = new StreamReader("autok.csv"))
            {
                string sor;
                while ((sor = sr.ReadLine()) != null);
                {

                }
            }
        }

        //List<> xdautok = new List<>();

    }
}
