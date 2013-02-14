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
    /// A bullet object meant to hurt people, porcupines, or pinapple.
    /// 
    /// Bullets inherit from projectile and add the capacity to deal damage.
    /// In this initial implementation, they will be a leaf class with its
    /// own image etc...
    /// </summary>
    class Bullet : Projectile
    {
        /// <summary>
        /// The constructor assumes that you are generating the bullet from a given location at a given velocity.
        /// </summary>
        /// <param name="location">The initial position for the bullet.</param>
        /// <param name="velocity">The initial velocity of the bullet.</param>
        public Bullet(Vector2 location, Vector2 velocity)
            : base(location,
                new Rectangle(0,0,20,20),
                new Rectangle(1,1,18,18))
        {
            this.Velocity = velocity;
        }

        /// <summary>
        /// Loads the bullet.
        /// </summary>
        /// <param name="contentManager">Using this content manager.</param>
        public override void  Load(ContentManager contentManager)
        {
            base.Load(contentManager);

            Texture2D bulletimage = contentManager.Load<Texture2D>("BulletSprite");

            if (bulletimage != null)
            {
                this.sprite.loadSprite(bulletimage, 2, 4, 0);

                this.sprite.addState("Forward Right", 0, 0);
                this.sprite.addState("Forward", 1, 1);
                this.sprite.addState("Forward Left", 2, 2);
                this.sprite.addState("Left", 3, 3);
                this.sprite.addState("Back Left", 4, 4);
                this.sprite.addState("Back", 5, 5);
                this.sprite.addState("Back Right", 6, 6);
                this.sprite.addState("Right", 7, 7);
            }
        }
    }
}