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
    /// An objective tailored for tracking a trigger. Once activated, the objective
    /// waits until the player has entered the target trigger. The objective is then
    /// complete.
    /// </summary>
    class TriggerObjective : Objective
    {
        /// <summary>
        /// The name of the trigger which this objective should be waiting for.
        /// </summary>
        public string TargetTrigger
        {
            get;
            set;
        }

        /// <summary>
        /// Constructs a functional Target Trigger that needs only be Initialized to be used.
        /// </summary>
        /// <param name="targetTriggerName">The name of the trigger to which the objective should refer.</param>
        public TriggerObjective(string targetTriggerName, int id) : base(id)
        {
            TargetTrigger = targetTriggerName;
            this.EventType = targetTriggerName + "Objective";
        }

        /// <summary>
        /// Initializes the objective... note that the name of the target trigger must still be set independently.
        /// </summary>
        /// <param name="gameReference">A reference to the game object to access the event manager.</param>
        public override void Initialize(Pantheon gameReference)
        {
            base.Initialize(gameReference);
        }

        public override void HandleNotification(Event eventinfo)
        {
            base.HandleNotification(eventinfo);

            Console.WriteLine(eventinfo.payload["Entity"] + " has collided with " + TargetTrigger + "\nObjective Complete!");
        }

        /// <summary>
        /// A very simple implementation for this functionality. In more complex objectives this function might
        /// be more verbose.
        /// </summary>
        /// <returns></returns>
        public override bool Complete()
        {
            return base.Complete();
        }

        public override void WrapUp(Pantheon gameReference)
        {
            base.WrapUp(gameReference);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            // Nothing much here either... please continue to... move along...
        }
    }
}
