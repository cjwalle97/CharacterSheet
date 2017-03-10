﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class Singleton
    {
        private DemonManager m_demonManager;

        public enum SingletonState
        {
            Init, Idle, Save, Load, Quit
        }

        public State Init = new State(SingletonState.Init);
        public State Idle = new State(SingletonState.Idle);
        public State Save = new State(SingletonState.Save);
        public State Load = new State(SingletonState.Load);
        public State Quit = new State(SingletonState.Quit);

        public DemonManager DemonManager
        {
            get { return m_demonManager; }
            set { m_demonManager = value; }
        }

        public delegate void Del();
        public Del Initializer;

        public void InitializeMainFSM()
        {
            DemonManager.MainFSM.AddTransition(SingletonState.Init.ToString(), DemonManager.MainFSM.GetState(Idle));
            DemonManager.MainFSM.AddTransition(SingletonState.Idle.ToString(), DemonManager.MainFSM.GetState(Save));
            DemonManager.MainFSM.AddTransition(SingletonState.Save.ToString(), DemonManager.MainFSM.GetState(Idle));
            DemonManager.MainFSM.AddTransition(SingletonState.Idle.ToString(), DemonManager.MainFSM.GetState(Load));
            DemonManager.MainFSM.AddTransition(SingletonState.Load.ToString(), DemonManager.MainFSM.GetState(Idle));
            DemonManager.MainFSM.AddTransition(SingletonState.Idle.ToString(), DemonManager.MainFSM.GetState(Quit));
        }
    }
}
