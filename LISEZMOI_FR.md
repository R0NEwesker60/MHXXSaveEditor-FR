# MHXXSwitchSaveEditor – version française (noms MHGU + interface traduite)

Programme de départ : MHXXSwitchSaveEditor 420.69 de Dawnshifter (GPL-3.0), lui-même basé sur
MHXXSaveEditor de mineminemine. **Ce programme a été modifié.** Licence : GPL-3.0 (fichier LICENSE).

## Modifications
- `Data/FrenchNames.cs` (nouveau) : noms français des objets, joyaux, armes, armures, talents, kinsectes,
  équipement et talents des Palicos, attaques de soutien, matchs de rancune, costumes, monstres, types
  d'équipement, points forts et cibles des Palicos, extraits des fichiers `.gmd` de MHGU et mis en
  correspondance par identifiant (position dans le fichier).
- Noms en double dans le jeu :
  - les 32 objets « Program Data » (copies internes des munitions, sans description) sont affichés
    « Normal (inutilisé) », « Glace (inutilisé) », etc. ;
  - la munition de capture est affichée « Tranquillisant (mun) » pour la distinguer du médicament
    « Tranquillisant » ;
  - un suffixe « (2) » est ajouté quand le jeu donne le même nom à deux vrais objets différents
    (Éclat Lagiacrus, Sondeur Najarala) ;
  - les emplacements « DUMMY » du jeu (sans objet réel) sont affichés « (Inutilisé N) » ou
    « (Joyau inutilisé N) ».
- `Util/Loc.cs` (nouveau) : traduction de l'interface, des messages et des menus déroulants, et menu
  **Language / Langue** (English / Français). Le choix est mémorisé (`%AppData%\MHXXSaveEditor\language.txt`) ;
  changer de langue redémarre le programme. Par défaut : français si Windows est en français, sinon anglais.
- Le programme lit les menus déroulants par position, pas par texte ; seul le mot du type d'équipement
  utilisé par la transmogrification est reconverti en anglais en interne (`Loc.EnType`).
- Le code d'origine (listes anglaises de `GameConstants.cs`) n'est pas modifié : les noms français les
  remplacent en mémoire au démarrage.
- Correction : l'écran « Chargement » n'est affiché qu'après le message de détection de la sauvegarde
  et il est refermé si le fichier est refusé.
- Correction : le code source d'origine contenait une ligne inachevée (`player.` dans `button1_Click_1`)
  qui empêchait la compilation ; elle a été retirée.
- Projet retargeté de .NET Framework 4.0 vers 4.8 ; signature ClickOnce désactivée ; dossier `publish` retiré.

## Reste en anglais
Quelques variantes de monstres propres à l'éditeur (« Furious Rajang »…), et les noms de l'éditeur pour
les emplacements sans nom dans le jeu.

## Compiler et lancer
Ouvrir `MHXXSaveEditor.sln` dans Visual Studio (charge de travail « Développement de bureau .NET »),
choisir **Release**, puis **Générer la solution**, puis **Démarrer**. Le programme se trouve aussi dans
`MHXXSaveEditor\bin\Release\MHXXSaveEditor.exe`. Faire une copie de sauvegarde avant d'ouvrir une vraie sauvegarde.
