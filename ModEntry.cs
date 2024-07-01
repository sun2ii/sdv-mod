using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
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
            Monitor.Log("New Day Started! Hi Emy and Yui!", LogLevel.Debug);
        }

        private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
        {
            if (e.Button == SButton.OemPlus && (e.IsDown(SButton.LeftShift) || e.IsDown(SButton.RightShift)))
            {
                GiveSpecificFish();
                Monitor.Log("Shift + + pressed", LogLevel.Info);
            }
            else if (e.Button == SButton.OemMinus && (e.IsDown(SButton.LeftShift) || e.IsDown(SButton.RightShift)))
            {
                CheckCompletionProgress();
                Monitor.Log("Shift + - pressed", LogLevel.Info);
            }
            else if (e.Button == SButton.OemQuotes && (e.IsDown(SButton.LeftShift) || e.IsDown(SButton.RightShift)))
            {
                OnAssetRequested();
                Monitor.Log("Shift + ' pressed", LogLevel.Info);
            }
            // You can add more functionality for other key combinations here
        }

        private void CheckCompletionProgress()
        {
            var stats = Game1.stats;
            uint itemsShipped = stats.ItemsShipped;
            uint fishCaught = stats.FishCaught;

            Monitor.Log($"Items Shipped: {itemsShipped}", LogLevel.Info);
            Monitor.Log($"Fish Caught: {fishCaught}", LogLevel.Info);
        }

        private void GiveSpecificFish()
        {
            string fishId = "163";
            var fish = new StardewValley.Object(fishId, 1);
            Game1.player.addItemByMenuIfNecessary(fish);
            Monitor.Log("You have received a Legend Fish!", LogLevel.Info);
        }

        private void OnAssetRequested()
        {
            try
            {
                // Texture2D portraits = helper.Content.Load<Texture2D>("Portraits/Abigail", ContentSource.GameContent);

                IDictionary<int, string> fishInfo = Game1.content.Load<Dictionary<int, string>>("Data\\Fish");
                // IDictionary<int, string> fishInfo = this.Helper.GameContent.Load<Dictionary<int, string>>("Data/Fish");

                // Define the path where you want to save the JSON file
                // string jsonFilePath = Path.Combine(fishInfo, "abigail-portrait.json");

                // // Serialize the dictionary to JSON
                // string jsonString = JsonSerializer.Serialize(fishInfo, new JsonSerializerOptions { WriteIndented = true });

                // // Write the JSON string to a file
                // File.WriteAllText(jsonFilePath, jsonString);

                // Log the success message
                // Monitor.Log("Fish info has been exported to " + jsonFilePath, LogLevel.Info);
                Monitor.Log(fishInfo);
            }
            catch (Exception ex)
            {
                Monitor.Log($"Error exporting fish info: {ex.Message}", LogLevel.Error);
            }
        }
    }
}