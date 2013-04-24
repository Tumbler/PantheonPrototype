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
    /// <summary>
    /// The base weapon
    /// </summary>
    class BoogerGun : Weapon
    {
        /// <summary>
        /// Initializes key values of a weapon.
        /// </summary>
        public BoogerGun(ContentManager Content)
            : base(Content.Load<Texture2D>("Sprites/Rifle"))
        {
            bulletType = "Booger";
            offset = .37;
            fireRate = 5;
            totalAmmo = 10;
            currentAmmo = totalAmmo;
            range = 750;
            speed = 30;
            damage = 5;
            reloadDelay = TimeSpan.FromSeconds(2);
            reloading = false;
            type = Type.WEAPON;
            ItemTag = "weapon";
            Info = "This is the Scar weapon\n" +
                   "   It has so/so range and\n" +
                   "   reload time. Also, watch\n" +
                   "   out for Butterflies carring\n" +
                   "   this weapon!";
        }

    }
}
