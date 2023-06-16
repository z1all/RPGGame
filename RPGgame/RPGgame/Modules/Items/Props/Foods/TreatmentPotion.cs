﻿using RPGgame.Modules.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgame.Modules.Items.Props
{
    internal class TreatmentPotion : Food
    {
        public TreatmentPotion() : base("Resources\\EntitySprites\\TreatmentPotion.png", new Effect()) { }
        
        public override void UseInStorage(Entity entity)
        {
            throw new Exception("useInStorage недоступен, так как функция не реализована");

        }
    }
}