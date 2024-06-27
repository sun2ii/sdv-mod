using System;
using StardewModdingAPI;
using StardewValley;
using StardewModdingAPI.Events;

namespace MyFirstMod
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            Monitor.Log("Ben's Mod initialized!", LogLevel.Debug);
            helper.Events.GameLoop.DayStarted += OnDayStarted;
            helper.Events.Input.ButtonPressed += this.OnButtonPressed;
        }

        private void OnDayStarted(object sender, EventArgs e)
        {
            Monitor.Log("New Day Started ! Hi Emy and Yui !", LogLevel.Debug);
        }

        private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
        {
            // Check if the 'P' key is pressed
            if (e.Button == SButton.P)
            {
                GiveSpecificFish();
            }
        }

        private void GiveSpecificFish()
        {
            // Example: Give the player a Legend Fish (ID 163)
            int fishId = 163;  // ID for the Legend Fish
            var fish = new StardewValley.Object("163", 1);
            Game1.player.addItemByMenuIfNecessary(fish);
            Monitor.Log("You have received a Legend Fish!", LogLevel.Info);
        }
    }
}