using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Serialization;

namespace CharacterSheet
{
    //Name: State
    //Type: Class
    //Description: allows for the creation of the States used in the FSMs
    class State
    {
        public State() { }
        public State(Enum e)
        {
            name = e.ToString();
        }
        public string name;
        public delegate void OnEnter();
        public delegate void OnExit();
        public OnEnter onEnter;
        public OnExit onExit;
        public void AddEnterFunction(Delegate d)
        {
            onEnter += d as OnEnter;
        }
        public void AddExitFunction(Delegate d)
        {
            onExit += d as OnExit;
        }
    }

    //Name: FSM
    //Type: Class
    //Description: A series of functions that form a Finite State Machine allowing the user to cycle through states
    class FSM<T>
    {
        Dictionary<string, State> states;
        private Dictionary<string, List<State>> transitions;
        State cState;

        public FSM()
        {
            states = new Dictionary<string, State>();
            transitions = new Dictionary<string, List<State>>();
            var v = Enum.GetValues(typeof(T));
            foreach (var e in v)
            {
                State s = new State(e as Enum);
                states.Add(s.name, s);
                transitions.Add(s.name, new List<State>());
            }
            cState = states.First().Value;
        }

        public void ChangeState(State state)
        {
            if (isValidTransition(state))
            {
                cState = state;

            }
        }

        public void AddTransition(string From, State To)
        {
            if (transitions.ContainsKey(From))
            {
                if (!transitions[From].Contains(To))
                    transitions[From].Add(To);
            }
        }

        public State GetState(T e)
        {
            State temp = new State(e as Enum);
            return states[temp.name];
        }

        private bool isValidTransition(State to)
        {
            var validStates = transitions[cState.name];
            if (validStates == null)
            {
                return false;
            }
            foreach (var state in validStates)
            {
                if (state == to)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
