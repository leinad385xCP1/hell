﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entregable1
{
    public class Character
    {
        private double life = 100;

        public string name;

        public Isword espada = new InitialSword();

        public Iarmor armadura = new InitialArmor();

        Random random = new Random();

        public Character(string name)
        {
            this.name = name;
        }

        public void Equip(Isword espada)
        {
            this.espada = espada;
        }

        public void Equip(Iarmor armadura)
        {
            this. armadura = armadura;
        } 
        

        public double Attack()
        {
            long HitOrMiss = random.NextInt64(1,5);

            if (HitOrMiss == 1) { Console.WriteLine("miss"); return 0; }
            else { return espada.damage(); }

            
        }

        public void DamageTaken(double damage)
        {
            this.life -= (damage*(armadura.resistencia()));
        }

        public double ShowCharacterLife()
        {
            return life;
        }

        public void Heal(double heal)
        {
            this.life += heal;
        }
 
    }
}
