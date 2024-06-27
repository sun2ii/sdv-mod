# Ben's Mod

## Description
MyFirstMod is a Stardew Valley mod that provides various functionalities to enhance your gameplay experience. This mod includes features like giving specific fish upon pressing a key combination and checking completion progress towards 100%.

## Features
- Press **Shift + =** to receive a Legend Fish.
- Press **Shift + -** to check your completion progress, including items shipped and fish caught.
- Additional key combinations with Shift for various actions:
  - **Shift + [**
  - **Shift + ]**
  - **Shift + ;**
  - **Shift + '**
  - **Shift + ,**
  - **Shift + .**

## Installation
1. **Download and Install SMAPI**: [SMAPI](https://smapi.io/)
2. **Clone or Download** this repository.
3. **Build the Project**:
   ```sh
   dotnet build
   ```

## Copy the mod files to your Stardew Valley Mods directory:
`cp bin/Debug/net6.0/BensMod.dll "/path/to/Stardew Valley/Mods/BensMod"`

## Usage
  1. Launch Stardew Valley through SMAPI.  
  2. Use the Key Combinations in-game to trigger mod functionalities:  
  •	Shift + =: Receive a Legend Fish.  
  •	Shift + -: Check completion progress.  
  •	Shift + [: Custom action.  
  •	Shift + ]: Custom action.  
  •	Shift + ;: Custom action.    
  •	Shift + ’: Custom action.  
  •	Shift + ,: Custom action.  
  •	Shift + .: Custom action.  

## Development
- Modify the Code: Edit ModEntry.cs to change or add functionalities.
-	Build and Test: Rebuild the project and use the SMAPI console reload command to test changes without restarting the game.

## Contributing
Feel free to fork this project, submit issues, and send pull requests.

## License
This project is licensed under the MIT License.