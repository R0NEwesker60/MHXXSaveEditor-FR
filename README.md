# MHXXSwitchSaveEditor – version française

> 🇫🇷 Français ci-dessous · 🇬🇧 English version further down

Éditeur de sauvegarde pour **Monster Hunter XX / Generations Ultimate (Switch et 3DS)**, avec une
**interface entièrement en français** et les **noms français officiels de MHGU** (objets, joyaux, armes,
armures, talents, kinsectes, équipement des Palicos…). Un menu **Language / Langue** permet de repasser
en anglais.

⚠️ **Faites toujours une copie de sauvegarde de votre fichier `system` avant de l'ouvrir.**
Ce programme peut abîmer une sauvegarde (voir l'avertissement d'origine plus bas).

## Origine du projet et crédits

Ce dépôt est un **fork modifié**. Je ne suis pas l'auteur de l'éditeur :

1. **mineminemine** – [MHXXSaveEditor](https://github.com/mineminemine/MHXXSaveEditor/) (éditeur 3DS d'origine) ;
2. **Dawnshifter** – MHXXSwitchSaveEditor, version 420.69 (ajout de la prise en charge des sauvegardes Switch,
   la base de ce dépôt) ;
3. **cette version** – traduction française et petites corrections (liste ci-dessous).

Tout le travail d'origine revient à ses auteurs. Ce dépôt reprend leur code sous la même licence.

## Ce qui a été modifié

- **Noms français de MHGU** extraits des fichiers texte du jeu et mis en correspondance par identifiant
  (`Data/FrenchNames.cs`, nouveau). Les listes anglaises d'origine (`GameConstants.cs`) ne sont pas modifiées.
- **Interface, messages et menus déroulants traduits**, avec un menu **Language / Langue**
  (`Util/Loc.cs`, nouveau). Le choix est mémorisé dans `%AppData%\MHXXSaveEditor\language.txt`.
- **Noms en double dans le jeu** : les copies internes des munitions (description « Program Data ») sont
  affichées « … (inutilisé) », la munition de capture « Tranquillisant (mun) », les emplacements vides du
  jeu « (Inutilisé N) ».
- **Corrections** : ligne inachevée dans le code d'origine (`player.`) qui empêchait la compilation ;
  écran « Chargement » qui masquait le message de détection de la sauvegarde.
- **Projet** : cible .NET Framework 4.8, signature ClickOnce désactivée.

Le détail est dans [`LISEZMOI_FR.md`](LISEZMOI_FR.md).

## Utilisation

1. Extraire la sauvegarde de MHXX/MHGU avec votre gestionnaire de sauvegardes (Checkpoint sur Switch).
2. **Copier** le fichier `system` (sauvegarde de sécurité).
3. Ouvrir `system` avec l'éditeur (menu *Fichier > Charger*), modifier, puis enregistrer.
4. Remettre `system` (et `system_backup`) à leur place et réimporter la sauvegarde.

Ne renommez pas les fichiers `system` et `system_backup`.

## Compiler

Visual Studio (charge de travail « Développement de bureau .NET », kit **.NET Framework 4.8**) :
ouvrir `MHXXSaveEditor.sln`, choisir **Release**, *Générer > Générer la solution*. L'exécutable est dans
`MHXXSaveEditor\bin\Release\MHXXSaveEditor.exe`.

## Licence

**GNU General Public License v3.0** (voir [`LICENSE`](LICENSE)), comme le projet d'origine. Les fichiers
modifiés ou ajoutés portent une mention de modification ; le code source complet est fourni ici.
Voir aussi [`NOTICE.md`](NOTICE.md).

Ce projet est **non officiel** et n'est lié ni à Capcom ni à Nintendo. Aucun fichier du jeu ni aucune
sauvegarde n'est fourni. *Monster Hunter* est une marque de Capcom ; les noms français des éléments du jeu
sont la propriété de Capcom et ne sont reproduits que pour l'interopérabilité de l'éditeur.

---

# MHXXSwitchSaveEditor – French version (English)

A save editor for **Monster Hunter XX / Generations Ultimate (Switch and 3DS)** with a **fully French UI**
and the **official French MHGU names** (items, decorations, weapons, armor, skills, kinsects, Palico gear…).
A **Language / Langue** menu switches back to English.

⚠️ **Always back up your `system` file before opening it.** This tool can corrupt a save.

**This is a modified fork, not the original work.** Credits: **mineminemine**
([MHXXSaveEditor](https://github.com/mineminemine/MHXXSaveEditor/)) → **Dawnshifter** (MHXXSwitchSaveEditor 420.69,
Switch support, the base of this repo) → this French version.

**Changes:** French names extracted from the game's text files and matched by ID (`Data/FrenchNames.cs`);
translated UI/messages/dropdowns with a language menu (`Util/Loc.cs`); duplicate item names disambiguated
("(inutilisé)" for the game's internal "Program Data" ammo copies, "(mun)" for the capture ammo);
fixes for a build-breaking unfinished line (`player.`) and for the loading screen covering the save-detection
message; retargeted to .NET Framework 4.8.

**Build:** Visual Studio, ".NET desktop development" workload + .NET Framework 4.8 targeting pack; open
`MHXXSaveEditor.sln`, Release, Build Solution.

**License:** GNU GPL v3.0 (see `LICENSE`). Unofficial; not affiliated with Capcom or Nintendo. No game files
or saves included. Game names are © Capcom, reproduced only for interoperability.

---

## Avertissement d'origine / Original README

> A save editor for Monster Hunter XX Switch and 3DS versions
> FIRST VERSION
> NOT TESTED THOROUGHLY ALWAYS MAKE A BACK UP
> THIS CAN AND PROBABLY WILL RUIN YOUR SAVE
>
> Based off: https://github.com/mineminemine/MHXXSaveEditor/
