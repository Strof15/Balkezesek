using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._05._25
{
    internal class Jatekos
    {
        string nev;
        string elso;
        string utolso;
        int suly;
        int magassag;

        public Jatekos(string nev, string elso, string utolso, int suly, int magassag)
        {
            this.nev = nev;
            this.elso = elso;
            this.utolso = utolso;
            this.suly = suly;
            this.magassag = magassag;
        }

        public string Nev { get => nev; }
        public string Elso { get => elso; }
        public string Utolso { get => utolso;  }
        public int Suly { get => suly; }
        public int Magassag { get => magassag; }

        //nev,elso  utolso suly magassag





    }
}
