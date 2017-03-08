using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class Demon: IDamageable
    {
        private string Name;
        private float Health;
        private float Mana;
        private float Strength;
        private float Magic;
        private float Dexterity;
        private float Agility;
        private float Luck;

        public Demon() { };
        public Demon(string n, float h, float r, float s, float m, float d, float a, float l)
        {
            Name = n;
            Health = h;
            Mana = r;
            Strength = s;
            Magic = m;
            Dexterity = d;
            Agility = a;
            Luck = l;
        }
    }
}
