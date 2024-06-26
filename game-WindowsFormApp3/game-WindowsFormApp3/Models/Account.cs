﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_WindowsFormApp3.Models
{
    public class Account
    {
        Random random = new Random();
        public string userName {  get; set; }   
        public string race { get; set; }
        public string branch { get; set; }
        public string weapon { get; set; }
        public int damage { get; set; }

        public void Attact()
        {
            
            damage = 0;
            if (race=="Human")
            {
                damage += 5;
            }
            else
            {
                damage += 10;
            }
            switch (branch)
            {
                case "Warrior":
                    damage += 40;
                    break;
                case "Mage":
                    damage += random.Next(30, 51);
                    break;
                case "Assasin":
                    damage += random.Next(10, 71);
                    break;
                case "Archer":
                    int number=random.Next(0, 2);
                    damage += number == 0 ? 5 : 10;
                    break;
            }
        }
    }
}
