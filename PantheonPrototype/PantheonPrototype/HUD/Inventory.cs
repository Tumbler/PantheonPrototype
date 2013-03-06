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
    /// This class keeps track of inventory stuff.
    /// </summary>
    class Inventory
    {
        public List<Rectangle> locationBoxes;
        public List<Rectangle> equippedBoxes;
        protected Texture2D inventorySelector; 

        private int SCREEN_WIDTH;
        private int SCREEN_HEIGHT;
        private int selected;
        private int hoveredOver;

        public Inventory(int SCREEN_WIDTH, int SCREEN_HEIGHT, ContentManager Content)
        {
            locationBoxes = new List<Rectangle>();
            equippedBoxes = new List<Rectangle>();

            this.SCREEN_WIDTH = SCREEN_WIDTH;
            this.SCREEN_HEIGHT = SCREEN_HEIGHT;

            SetBoxes();

            selected = -1;
            hoveredOver = -1;

            inventorySelector = Content.Load<Texture2D>("InvSelect");
        }

        /// <summary>
        /// The inventory Selector png
        /// </summary>
        public Texture2D InventorySelector
        {
            get { return inventorySelector; }
        }

        /// <summary>
        /// Sets the selected item in the inventory
        /// </summary>
        public int Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        /// <summary>
        /// Updates which item is being hovered over
        /// </summary>
        public int HoveredOver
        {
            get { return hoveredOver; }
            set { hoveredOver = value; }
        }

        /// <summary>
        /// Basically hardcodes the different square areas for item's HUDrepresentation to go.
        /// </summary>
        private void SetBoxes()
        {
            // Add Inventory slots
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    locationBoxes.Add(new Rectangle((int)((.025 * SCREEN_WIDTH) + i * (.1 * SCREEN_WIDTH)), (int)((.041 * SCREEN_HEIGHT) + j * (.167 * SCREEN_HEIGHT)),
                        (int)(.1 * SCREEN_WIDTH), (int)((.167 * SCREEN_HEIGHT))));
                }
            }

            // Add Equipped slots
            for (int i = 0; i < 2; i++)
            {
                equippedBoxes.Add(new Rectangle((int)((.025 * SCREEN_WIDTH) + i * (.1 * SCREEN_WIDTH)), (int)(.792 * SCREEN_HEIGHT), 
                    (int)(.1 * SCREEN_WIDTH), (int)(.167 * SCREEN_HEIGHT)));
            }
            for (int i = 0; i < 4; i++)
            {
                equippedBoxes.Add(new Rectangle((int)((.301 * SCREEN_WIDTH) + i * (.1 * SCREEN_WIDTH)), (int)(.792 * SCREEN_HEIGHT),
                    (int)(.1 * SCREEN_WIDTH), (int)(.167 * SCREEN_HEIGHT)));
            }
            equippedBoxes.Add(new Rectangle((int)(.775 * SCREEN_WIDTH), (int)(.792 * SCREEN_HEIGHT), (int)(.1 * SCREEN_WIDTH), (int)(.167 * SCREEN_HEIGHT)));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (hoveredOver != -1)
            {
                if (hoveredOver < 24)
                {
                    spriteBatch.Draw(inventorySelector, locationBoxes[hoveredOver], Color.White);
                }
                else
                {
                    spriteBatch.Draw(inventorySelector, equippedBoxes[hoveredOver - 24], Color.White);
                }
            }

        }
    }
}