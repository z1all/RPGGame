﻿using RPGgame.Modules.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgame.Modules.Items.Props
{
    internal class MeleeWeapons : Weapon
    {
        public MeleeWeapons(string path, Effect effect) : base(path, effect) { }

        public int AttackPower { get; private set; }
        public float DistanceOfAttack { get; private set; }

        public override void Attack(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}