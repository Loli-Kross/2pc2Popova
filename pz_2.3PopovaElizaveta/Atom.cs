using System;

namespace pz_2._3PopovaElizaveta
{
    class Atom
    {
        static void Main(string[] args)
        {
            Atom atom = new Atom("Ксенон", 54);
            atom.GetInfo();
            Atom atom1 = new Atom("Унбитрий");
            atom1.GetInfo();
            Atom atom2 = new Atom(68, 167.26f);
            atom2.GetInfo();
            Atom atom3 = new Atom("Нептуний", 93, 237.0482f, "3 - 4");
            atom3.GetInfo();
        }
        public string name;
        public int countElectrons;
        public float mass;
        public string valence;
        public Atom(string s) {name = s;}
        public Atom(int c) {countElectrons = c;}
        public Atom(float m) {mass = m;}
        public Atom(string s, int c) {name = s; countElectrons = c;}
        public Atom(string s, float m) {name = s; mass = m;}
        public Atom(string s, string v) {name = s; valence = v;}
        public Atom(int c, float m) {countElectrons = c; mass = m;}
        public Atom(int c, string v) {countElectrons = c; valence = v;}
        public Atom(float m, string v) {mass = m; valence = v;}
        public Atom(string s, int c, float m) {name = s; countElectrons = c; mass = m;}
        public Atom(string s, int c, string v) {name = s; countElectrons = c; valence = v;}
        public Atom(string s, float m, string v) {name = s; mass = m; valence = v;}
        public Atom(int c, float m, string v) {countElectrons = c; mass = m; valence = v;}
        public Atom(string s, int c, float m, string v) {name = s; countElectrons = c; mass = m; valence = v;}
        public void GetInfo()
        {
            Console.WriteLine($"Название: {name}\nПорядковый номер: {countElectrons}\nМасса: {mass}\nВалентность: {valence}");
        }
    }
}
