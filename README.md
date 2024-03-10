# Localizash - Localization Tool for Unity

## Description

**Localizash** is a comprehensive localization package designed for Unity developers aiming to streamline the implementation of multi-language support in their games. 
This tool allows seamless integration of language data, which can be sourced from Google Sheets, directly imported from JSON files, or manually entered by the user. 
To ensure compatibility and ease of use, Localizash utilizes the `com.unity.nuget.newtonsoft-json` package for JSON operations, making it mandatory for users to have this package in their Unity project.

## How to Install

In the Unity editor, open Pakage Manager (Window -> Package Manager). Then press the "+" icon in the upper right corner and select "Add package from git URL..." and paste there the link to this repository `https://github.com/wazash/localizash.git` and then press "Add".

## How to Use

1. **Setting Up Localizash:**
   - **Localization Manager** manage translatioan in your project. Add a `LocalizationManager` component to the GameObject. It requires a LoccalizationData ScriptableObject.
     
     ![Localization Manager image](https://dl.dropboxusercontent.com/scl/fi/x4axqipnvkmnu1ee0ggg5/localization-manager.png?rlkey=y6qc5e8yow6dkm9go93o8ef5z&dl=0)
     
   - **LocalizationData** is a container for all translations for your game. It's a list of word keys and language codes and translation pairs. You can create it by right-clicking in the project window and choosing `Create -> Localization -> LocalizationData`.
  
     ![Creating LocalizationData](https://dl.dropboxusercontent.com/scl/fi/hp52k20asyjqqone3wkw0/data-create.png?rlkey=p1o5ei96070ikq7qt1skwgv51&dl=0)
     
   - You can set `LocalizatonData` manually or use Google Sheet or JSON file (more information in section Importing Language Data).
   - When you set your `LocalizationData` SO, you can simply add UI element with TextMeshProUGUI component (Text, Button) and assign `LocalizedUI` component to it.
   - Then fill the Key field with the correct word key and Localizash will do the rest of the work.
  
     ![Place to put word key](https://dl.dropboxusercontent.com/scl/fi/tqt2xneo64znctt9yj2it/localized-ui.png?rlkey=df0job75irzaep1jaykhikoy1&dl=0)
     
2. **Import Language Data:**.
   - **Google Sheets:** Localizash can download language data directly from a specified Google Sheets document. Make sure the sheet is publicly accessible or shared with a service account linked to Localizash. Then add the `SheetsDownloaderManager` into the GameObjet, fill in the Google Sheet URL field with the correct URL address and the LocalizationData string and press the **"Fetch Data"** button.

     ![URL for Google Sheets place](https://dl.dropboxusercontent.com/scl/fi/il5p3pzlbymmovjr4xf9s/downloader-manager.png?rlkey=kwqbupg4m60usruqbj8mccw0y&dl=0)
     
   - **JSON file:** If you prefer to use local JSON files, place them in the project folder. Localizash will parse them. Add a `GeneratorLocDataFromJSON` component into the GameObject, then paste the JSON file into the JSON Asset field and press the "Populate Data" button. **Warning! JSON file must have the correct syntax, which is shown below!**

     ![JSON file syntax](https://dl.dropboxusercontent.com/scl/fi/p7l3mycdj0s0cujwaz28s/json-blueprint.png?rlkey=eypu6wir6lt9zu6x05tp707so&dl=0)
     
   - **Manual Entry:** You can also manually enter localization data directly into the Localizash interface within Unity, providing an easy way to add or edit language entries.
  
   - ![You can fill LocalizationData manually](https://dl.dropboxusercontent.com/scl/fi/cl3pkq6cctb9pmf70igyl/localization-data.png?rlkey=udqh744eavkqab8zn5tn85xzj&dl=0)

3. **Works With Dropdown:**.
   - **Unity dropdown** is integrated. Just add `LanguageDropdownManager` into GameObject and assing dropdown into field. Now dropdown values will updated to all supported languages (depends on language codes in `LocalizationData` SO) and show languages names based on `OriginalLanguageNames Dictionary` inside `LocalizationData.cs`. Also changing language from dropdown will refresh all `LocalizedUI` components.

![Dropdown implementation](https://dl.dropboxusercontent.com/scl/fi/5so6xq7urphs9tybpeq13/dropdown-manager.png?rlkey=q3xbhxtq5xse57h0p43vilwfc&dl=0) 
![Original Language Names Ditionary](https://dl.dropboxusercontent.com/scl/fi/it8ytrx0g4m2cig9s0dmh/language-codes.png?rlkey=rhjmoahmkuy0ukv9muuoghycu&dl=0)

4. **Localizash Assets:** If you want, you can use the prepared assets and sample data. Simply find `Localizash - Localization Tool` in the Packages folder and search the Plugins folder.

5. **Utilizing Localization in Your Game:**
   - Integrate the Localizash API calls in your game scripts to dynamically load and display the appropriate language text, ensuring a seamless experience for users across different languages.

![Presentation](https://dl.dropboxusercontent.com/scl/fi/wy374hgts8zw6pllqqep5/localizash-presentation.gif?rlkey=okk0yns358xefq9u6re27aq18&dl=0)

By leveraging the power of **Localizash**, developers can significantly reduce the complexity of implementing a robust localization system in their Unity games, making it an essential tool for global game releases.
