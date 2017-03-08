using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class Singleton
    {

        private Demon m_Demon;
        private MainFSM;

        public Demon Demon
        {
            get { return m_Demon; }
            set { m_Demon = value; }
        }

        public delegate void Del();
        public Del Initializer;

        public static Singleton Instance
        {
            get { return Instance; }
        }

        private Singleton ()
        {
            DemonStorer a = new DemonStorer();
        }
    }
}
