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
            if (e.Button == SButton.Plus && (e.IsDown(SButton.LeftShift) || e.IsDown(SButton.RightShift)))
            {
                GiveSpecificFish();
            }
            // Check if the Shift key and '-' key are pressed
            else if (e.Button == SButton.Minus && (e.IsDown(SButton.LeftShift) || e.IsDown(SButton.RightShift)))
            {
                CheckCompletionProgress();
            }
            else if (e.Button == SButton.OpenBracket && (e.IsDown(SButton.LeftShift) || e.IsDown(SButton.RightShift)))
            {
                Monitor.Log("Shift + [ pressed", LogLevel.Info);
            }
            else if (e.Button == SButton.CloseBracket && (e.IsDown(SButton.LeftShift) || e.IsDown(SButton.RightShift)))
            {
                // Add your specific action here
                Monitor.Log("Shift + ] pressed", LogLevel.Info);
            }
            else if (e.Button == SButton.Semicolon && (e.IsDown(SButton.LeftShift) || e.IsDown(SButton.RightShift)))
            {
                Monitor.Log("Shift + ; pressed", LogLevel.Info);
            }
            else if (e.Button == SButton.Apostrophe && (e.IsDown(SButton.LeftShift) || e.IsDown(SButton.RightShift)))
            {
                Monitor.Log("Shift + ' pressed", LogLevel.Info);
            }
            else if (e.Button == SButton.Comma && (e.IsDown(SButton.LeftShift) || e.IsDown(SButton.RightShift)))
            {
                Monitor.Log("Shift + , pressed", LogLevel.Info);
            }
            else if (e.Button == SButton.Period && (e.IsDown(SButton.LeftShift) || e.IsDown(SButton.RightShift)))
            {
                Monitor.Log("Shift + . pressed", LogLevel.Info);
            }

            private void CheckCompletionProgress()
            {
                var stats = Game1.stats;
                uint itemsShipped = stats.ItemsShipped;
                uint fishCaught = stats.FishCaught;

                // Display messages in the chat box
                Game1.addHUDMessage(new HUDMessage($"Items Shipped: {itemsShipped}", 3));
                Game1.addHUDMessage(new HUDMessage($"Fish Caught: {fishCaught}", 3));

                // Calculate a simple progress percentage (example)
                double progress = (itemsShipped >= 1 ? 0.5 : 0) + (fishCaught >= 1 ? 0.5 : 0);
                Game1.addHUDMessage(new HUDMessage($"Completion progress: {progress * 100}%", 3));
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