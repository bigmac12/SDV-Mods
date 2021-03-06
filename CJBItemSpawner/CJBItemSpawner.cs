﻿using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace CJBItemSpawner
{
    public class CJBItemSpawner : Mod {
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper) {
            ControlEvents.KeyPressed += Events_KeyPressed;
        }

        private void Events_KeyPressed(object sender, EventArgsKeyPressed e) {
            if (e.KeyPressed == Microsoft.Xna.Framework.Input.Keys.I) {
                if (Game1.hasLoadedGame && Game1.activeClickableMenu == null && Game1.player.CanMove && !Game1.dialogueUp && !Game1.eventUp) {
                    ItemMenu.Open();
                }
            }
        }
    }
}
