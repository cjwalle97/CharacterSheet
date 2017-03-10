using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CharacterSheet
{
    //Name: DemonManager
    //Type: class
    //Description: meant to handle use of FSM's in regards to the Demon class
    class DemonManager
    {
        private FSM<State> m_mainfsm;
        private Demon m_currentdemon;

        public FSM<State> MainFSM
        {
            get { return m_mainfsm; }
            set { m_mainfsm = value; }
        }

        public Demon CurrentDemon
        {
            get { return m_currentdemon; }
        }

        public DemonManager()
        {
            MainFSM = new FSM<State>();
        }
    }
}
