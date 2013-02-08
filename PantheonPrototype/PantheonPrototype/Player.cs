﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PantheonPrototype
{
    class Player : CharacterEntity
    {
        Player()
        {
            TotalArmor = 100;
            CurrentArmor = 75;
            ShieldCapacity = 100;
            ShieldStrength = 100;
        }
    }
}
