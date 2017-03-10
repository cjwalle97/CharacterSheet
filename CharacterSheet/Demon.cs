using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CharacterSheet
{
    //Name: Demon
    //Type: class
    //Description: A class that contains a series of stats such as Health, Mana, Strength, etc. Meant to be used in serialization.
    public class Demon
    {
        private string Name;
        private float Health;
        private float Mana;
        private float Strength;
        private float Magic;
        private float Dexterity;
        private float Agility;
        private float Luck;

        public Demon() { }
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
        public string AccessName()
        {
            string text = Name;
            return text;
        }
        public float AccessHealth()
        {
            float Number = Health;
            return Number;
        }
        public float AccessMana()
        {
            float Number = Mana;
            return Number;
        }
        public float AccessStrength()
        {
            float Number = Strength;
            return Number;
        }
        public float AccessMagic()
        {
            float Number = Magic;
            return Number;
        }
        public float AccessDexterity()
        {
            float Number = Dexterity;
            return Number;
        }
        public float AccessAgility()
        {
            float Number = Agility;
            return Number;
        }
        public float AccessLuck()
        {
            float Number = Luck;
            return Number;
        }
    }
}
