// MHXXSwitchSaveEditor – version française (modifiée). Licence : GNU GPL v3 (voir LICENSE).
// Basé sur MHXXSwitchSaveEditor 420.69 (Dawnshifter), lui-même basé sur MHXXSaveEditor (mineminemine).
// Fichier ajouté lors de la traduction française, le 12 novembre 2026.
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MHXXSaveEditor
{
    // Gestion de la langue (anglais / français) : traduction de l'interface et des messages.
    static class Loc
    {
        public static bool French = false;

        static readonly Dictionary<string, string> fr = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "General", "Général" },
            { "Name", "Nom" },
            { "Street Passes", "StreetPass" },
            { "Play Time", "Temps de jeu" },
            { "Guild Card ID", "ID de la carte de chasseur" },
            { "Quests", "Quêtes" },
            { "G Rank", "Rang G" },
            { "Arena", "Arène" },
            { "Special Permit", "Permis spécial" },
            { "Hunter Hub (High)", "Hub des chasseurs (haut rang)" },
            { "Hunter Hub (Low)", "Hub des chasseurs (bas rang)" },
            { "Village (High)", "Village (haut rang)" },
            { "Village (Low)", "Village (bas rang)" },
            { "Weapons", "Armes" },
            { "Hunter Hub", "Hub des chasseurs" },
            { "Village", "Village" },
            { "Weapon", "Arme" },
            { "Monsters", "Monstres" },
            { "Largest Size (%)", "Plus grande taille (%)" },
            { "Smallest Size (%)", "Plus petite taille (%)" },
            { "Capture", "Capture" },
            { "Kill", "Abattus" },
            { "Monster", "Monstre" },
            { "Grudge Matches", "Matchs de rancune" },
            { "Grade", "Grade" },
            { "Weapon Type", "Type d'arme" },
            { "Best Time (seconds)", "Meilleur temps (secondes)" },
            { "Rank", "Rang" },
            { "Best Time", "Meilleur temps" },
            { "OK", "OK" },
            { "Cancel", "Annuler" },
            { "Editing Guild Card", "Modification de la carte de chasseur" },
            { "Type", "Type" },
            { "Level", "Niveau" },
            { "Power Lv", "Niv. puissance" },
            { "Speed Lv", "Niv. vitesse" },
            { "Weight Lv", "Niv. poids" },
            { "Fire Lv", "Niv. feu" },
            { "Water Lv", "Niv. eau" },
            { "Thunder Lv", "Niv. foudre" },
            { "Ice Lv", "Niv. glace" },
            { "Dragon Lv", "Niv. dragon" },
            { "Save", "Enregistrer" },
            { "Element", "Élément" },
            { "Stats", "Stats" },
            { "Kinsect", "Kinsecte" },
            { "Stats Exp", "Exp. des stats" },
            { "Power Exp", "Exp. puissance" },
            { "Speed Exp", "Exp. vitesse" },
            { "Weight Exp", "Exp. poids" },
            { "Element Exp", "Exp. élément" },
            { "Fire Exp", "Exp. feu" },
            { "Water Exp", "Exp. eau" },
            { "Thunder Exp", "Exp. foudre" },
            { "Ice Exp", "Exp. glace" },
            { "Dragon Exp", "Exp. dragon" },
            { "Editing Kinsect", "Modification du kinsecte" },
            { "Forte Specific ID", "ID spécifique du point fort" },
            { "Original Owner ID", "ID du propriétaire d'origine" },
            { "Palico ID", "ID du Palico" },
            { "Status :", "Statut :" },
            { "Detail", "Détail" },
            { "Greeting", "Salutation" },
            { "Previous Owner", "Ancien propriétaire" },
            { "Name Giver", "Donneur du nom" },
            { "Learned Skill RNG", "RNG des talents appris" },
            { "Learned Action RNG", "RNG des actions apprises" },
            { "Target", "Cible" },
            { "Enthusiasm", "Enthousiasme" },
            { "Forte", "Point fort" },
            { "Exp", "Exp." },
            { "Design", "Apparence" },
            { "Vest RGBA Value", "Valeur RGBA du gilet" },
            { "Right Eye RGBA Value", "Valeur RGBA de l'œil droit" },
            { "Left Eye RGBA Value", "Valeur RGBA de l'œil gauche" },
            { "Coat RGBA Value", "Valeur RGBA du pelage" },
            { "Tail", "Queue" },
            { "Ears", "Oreilles" },
            { "Coat", "Pelage" },
            { "Clothing", "Vêtements" },
            { "Eyes", "Yeux" },
            { "Voice", "Voix" },
            { "Equipped Actions", "Actions équipées" },
            { "Slot", "Emplacement" },
            { "Actions", "Actions" },
            { "Equipped Skills", "Talents équipés" },
            { "Skills", "Talents" },
            { "Learned Actions", "Actions apprises" },
            { "Learned Skills", "Talents appris" },
            { "Export", "Exporter" },
            { "Import", "Importer" },
            { "Editing Palico", "Modification du Palico" },
            { "Shoutout", "Annonce" },
            { "Manual Shoutouts", "Annonces manuelles" },
            { "Set", "Définir" },
            { "Automatic Shoutouts", "Annonces automatiques" },
            { "Editing Shoutouts", "Modification des annonces" },
            { "Skill 2", "Talent 2" },
            { "Skill 1", "Talent 1" },
            { "Slots", "Emplacements" },
            { "Editing Talisman", "Modification du talisman" },
            { "File", "Fichier" },
            { "Select Save Slot", "Choisir l'emplacement de sauvegarde" },
            { "Load", "Charger" },
            { "Save As", "Enregistrer sous" },
            { "Delete Save Slot", "Supprimer l'emplacement de sauvegarde" },
            { "Slot 1", "Emplacement 1" },
            { "Slot 2", "Emplacement 2" },
            { "Slot 3", "Emplacement 3" },
            { "Exit", "Quitter" },
            { "Edit", "Modifier" },
            { "Item Box", "Coffre à objets" },
            { "Max Amount", "Quantité max." },
            { "Set Amount To", "Définir la quantité à" },
            { "Remove Duplicates", "Supprimer les doublons" },
            { "Remove All Items", "Supprimer tous les objets" },
            { "Import From", "Importer depuis" },
            { "Export To", "Exporter vers" },
            { "Equipment Box", "Coffre d'équipement" },
            { "Convert", "Convertir" },
            { "To Switch", "Vers Switch" },
            { "To 3DS", "Vers 3DS" },
            { "Help", "Aide" },
            { "About", "À propos" },
            { "Visit main thread", "Visiter le sujet principal" },
            { "Visit Github page", "Visiter la page GitHub" },
            { "Edit Guild Card", "Modifier la carte de chasseur" },
            { "Edit Shoutouts", "Annonces" },
            { "Play Time (sec)", "Temps de jeu (sec)" },
            { "Yukumo Points", "Points de Yukumo" },
            { "Pokke Points", "Points de Pokke" },
            { "Kokoto Points", "Points de Kokoto" },
            { "Bherna Points", "Points de Bherna" },
            { "Academy Points", "Points de l'Académie" },
            { "Funds", "Fonds" },
            { "HR Points", "Points de RC" },
            { "HR Level", "Rang de chasseur (RC)" },
            { "Player", "Joueur" },
            { "Clothes", "Vêtements" },
            { "Features", "Traits" },
            { "Hair", "Cheveux" },
            { "Skin", "Peau" },
            { "Eye Color", "Couleur des yeux" },
            { "Face", "Visage" },
            { "Hairstyle", "Coiffure" },
            { "Gender", "Genre" },
            { "Clear Slot", "Vider l'emplacement" },
            { "Amount", "Quantité" },
            { "Item", "Objet" },
            { "Item Name", "Nom de l'objet" },
            { "Equipment", "Équipement" },
            { "Transmogrify", "Transmogrifier" },
            { "Edit Talisman", "Talisman" },
            { "Edit Kinsect", "Kinsecte" },
            { "Deco 3", "Joyau 3" },
            { "Deco 2", "Joyau 2" },
            { "Deco 1", "Joyau 1" },
            { "Palico", "Palico" },
            { "Edit Palico", "Palico" },
            { "Palico Equip", "Équipement Palico" },
            { "MHXX Save Editor", "Éditeur de sauvegarde MHXX" },
            { "Set All Item Amount to", "Définir toutes les quantités d'objets à" },
            { "Loading your save file..\r\nPlease wait..", "Chargement de votre sauvegarde..\r\nVeuillez patienter.." },
            { "Loading..", "Chargement.." },
            { "Transmogrify To", "Transmogrifier en" },
            { "Palico has been exported", "Le Palico a été exporté" },
            { "Export Palico", "Exporter un Palico" },
            { "Are you sure you want to import another palico to this slot?", "Voulez-vous vraiment importer un autre Palico dans cet emplacement ?" },
            { "Import Palico", "Importer un Palico" },
            { "This is not a Palico file.", "Ce n'est pas un fichier de Palico." },
            { "Error", "Erreur" },
            { "Palico file successfully imported.", "Fichier de Palico importé avec succès." },
            { "Shoutout has been set", "L'annonce a été définie" },
            { "It is likely that this talisman you are trying to edit is invalid and will not work in-game, please remove this talisman and add in a new one.", "Ce talisman est probablement invalide et ne fonctionnera pas en jeu. Supprimez-le et ajoutez-en un nouveau." },
            { "Detected a 3DS save", "Sauvegarde 3DS détectée" },
            { "Detected a MHXX Switch save", "Sauvegarde MHXX Switch détectée" },
            { "Detected a MHGU Switch save", "Sauvegarde MHGU Switch détectée" },
            { "Switch", "Switch" },
            { "Invalid save format", "Format de sauvegarde invalide" },
            { "No existing save slots used, please make one in-game first.", "Aucun emplacement de sauvegarde utilisé, créez-en un d'abord en jeu." },
            { "File saved", "Fichier enregistré" },
            { "Saved !", "Enregistré !" },
            { "Made by Dawnshifter based on work of Ukee for GBATemp\nBased off APM's MHX/MHGen Save Editor\nAlso thanks to Seth VanHeulen for the Save File structure\nAnd some MHX/MHGen/MHXX hex editing threads in GBATemp", "Réalisé par Dawnshifter d'après le travail d'Ukee pour GBATemp\nBasé sur l'éditeur de sauvegarde MHX/MHGen d'APM\nMerci aussi à Seth VanHeulen pour la structure du fichier de sauvegarde\nEt à quelques sujets de modification hexadécimale MHX/MHGen/MHXX sur GBATemp" },
            { "An unknown item was found at slot: {0}\nYou may have an invalid item in your item box\nIf you proceed to try and edit it, you may get a crash", "Un objet inconnu a été trouvé à l'emplacement : {0}\nVotre coffre à objets contient peut-être un objet invalide\nSi vous essayez de le modifier, le programme risque de planter" },
            { "Item Error", "Erreur d'objet" },
            { "Click OK to copy this message", "Cliquez sur OK pour copier ce message" },
            { "Item ID: {0}", "ID de l'objet : {0}" },
            { "An unknown equipment was found at slot: {0}\nYou may have an invalid equipment in your equipment box\nIf you proceed to try and edit it, you may get a crash", "Un équipement inconnu a été trouvé à l'emplacement : {0}\nVotre coffre d'équipement contient peut-être un équipement invalide\nSi vous essayez de le modifier, le programme risque de planter" },
            { "Equipment Error", "Erreur d'équipement" },
            { "All item amount have been set to 99", "Toutes les quantités d'objets ont été définies à 99" },
            { "Please select a palico first!\nIf you don't have any, please hire one from in-game first.", "Sélectionnez d'abord un Palico !\nSi vous n'en avez pas, engagez-en un en jeu." },
            { "Duplicate items have been removed", "Les objets en double ont été supprimés" },
            { "All items have been removed", "Tous les objets ont été supprimés" },
            { "Do you wish visit the main thread?", "Voulez-vous visiter le sujet principal ?" },
            { "Visit Main Thread", "Visiter le sujet principal" },
            { "Do you wish visit Github page?", "Voulez-vous visiter la page GitHub ?" },
            { "Visit Github", "Visiter GitHub" },
            { "Are you sure you want to delete this save slot?", "Voulez-vous vraiment supprimer cet emplacement de sauvegarde ?" },
            { "Delete save slot 1", "Supprimer l'emplacement 1" },
            { "Delete save slot 2", "Supprimer l'emplacement 2" },
            { "Delete save slot 3", "Supprimer l'emplacement 3" },
            { "The save slot has been deleted", "L'emplacement de sauvegarde a été supprimé" },
            { "Save slot {0} deleted", "Emplacement {0} supprimé" },
            { "This program will now restart", "Le programme va redémarrer" },
            { "Transmogrifying - {0}", "Transmogrification - {0}" },
            { "Are you sure you want to import from another item box list?", "Voulez-vous vraiment importer depuis une autre liste du coffre à objets ?" },
            { "Import Item Box", "Importer le coffre à objets" },
            { "Item Box has been exported to {0}", "Le coffre à objets a été exporté vers {0}" },
            { "Export Item Box", "Exporter le coffre à objets" },
            { "Equipment Box has been exported to {0}", "Le coffre d'équipement a été exporté vers {0}" },
            { "Export Equipment Box", "Exporter le coffre d'équipement" },
            { "Warning!\nPlease make sure your equipped weapons/armor are only from Box 1-8 or you will likely get crashed in-game.\n\nAre you sure you want to import from another equipment box list?\nOnly equips in Box 9-20 will be imported", "Attention !\nVérifiez que vos armes/armures équipées proviennent uniquement des coffres 1 à 8, sinon le jeu risque de planter.\n\nVoulez-vous vraiment importer depuis une autre liste du coffre d'équipement ?\nSeuls les équipements des coffres 9 à 20 seront importés" },
            { "Equipment has been imported, you may find them starting from slot 800-2000", "L'équipement a été importé, vous le trouverez à partir des emplacements 800-2000" },
            { "Import Equipment Box", "Importer le coffre d'équipement" },
            { "Please select a MHXX Switch save created by your own switch (can be an empty save file).", "Sélectionnez une sauvegarde MHXX Switch créée par votre propre Switch (elle peut être vide)." },
            { "Switch save", "Sauvegarde Switch" },
            { "Not a valid switch save", "Sauvegarde Switch invalide" },
            { "You are now editing the switch version of this save", "Vous modifiez maintenant la version Switch de cette sauvegarde" },
            { "Conversion complete", "Conversion terminée" },
            { "You are now editing the 3DS version of this save.", "Vous modifiez maintenant la version 3DS de cette sauvegarde." },
            { "Coverted to 3DS", "Converti en 3DS" },
            { "Please select the MHXX Switch save", "Sélectionnez la sauvegarde MHXX Switch" },
            { "MHXX save", "Sauvegarde MHXX" },
            { "Please select the MHGU Switch save", "Sélectionnez la sauvegarde MHGU Switch" },
            { "MHGU save", "Sauvegarde MHGU" },
            { "3DS", "3DS" },
            { "This palico is selected for Prowler Mode", "Ce Palico est sélectionné pour le mode Miaroudeur" },
            { "This palico is selected for ordering items", "Ce Palico est sélectionné pour commander des objets" },
            { "This palico is selected for Palico Dojo/Catnap/Meditation", "Ce Palico est sélectionné pour le Dojo Palico / la sieste / la méditation" },
            { "Not sure what this palico is doing..", "On ne sait pas trop ce que fait ce Palico.." },
            { "This palico is selected for Normal Traning", "Ce Palico est sélectionné pour l'entraînement normal" },
            { "This palico is not hired; check with the Palico Sellers", "Ce Palico n'est pas engagé ; voyez les vendeurs de Palicos" },
            { "This palico is resting; not doing anything", "Ce Palico se repose ; il ne fait rien" },
            { "This palico is selected as the First Palico for hunting", "Ce Palico est le premier Palico de chasse" },
            { "This palico is selected as the Second Palico for hunting", "Ce Palico est le second Palico de chasse" },
            { "This palico is on a Meownster Hunt", "Ce Palico est en Chasse Miaouster" },
            { "This DLC palico is resting; not doing anything", "Ce Palico DLC se repose ; il ne fait rien" },
            { "This DLC palico is selected as the First Palico for hunting", "Ce Palico DLC est le premier Palico de chasse" },
            { "This DLC palico is selected as the Second Palico for hunting", "Ce Palico DLC est le second Palico de chasse" },
            { "This DLC palico is on a Meownster Hunt", "Ce Palico DLC est en Chasse Miaouster" },
            { "Not sure what this palico is doing [{0}]", "On ne sait pas trop ce que fait ce Palico [{0}]" },
        };

        // Correspondance « libellé français -> libellé anglais d'origine » pour les types d'équipement :
        // le programme compare ces mots anglais en interne (transmogrification).
        static readonly Dictionary<string, string> frToEn = new Dictionary<string, string>();

        public static string EnType(string s)
        {
            string r;
            return (s != null && frToEn.TryGetValue(s, out r)) ? r : s;
        }

        // Menus déroulants définis dans les fenêtres (le programme les lit par position, jamais par texte).
        static readonly Dictionary<string, string[]> comboFr = new Dictionary<string, string[]>
        {
            { "comboBoxGender", new string[] { "Homme", "Femme" } },
            { "comboBoxTail", new string[] { "Standard", "Ronde", "Tordue", "Touffue", "Longue" } },
            { "comboBoxEars", new string[] { "Standard", "Tombantes", "Attentives", "Dressées", "Rondes" } },
            { "comboBoxCoat", new string[] { "Felyne", "Melynx", "Rayé", "Monotone", "Bicolore", "Tricolore", "Tigré" } },
            { "comboBoxClothing", new string[] { "Gilet", "Tablier" } },
            { "comboBoxEyes", new string[] { "Standard", "Fins", "Perçants", "Biche", "Rapprochés", "Cicatrice" } },
            { "comboBoxVoice", new string[] { "Aucune", "Normale", "Aiguë", "Grave" } }
        };

        static void TranslateCombo(ComboBox cb)
        {
            string[] items;
            if (!comboFr.TryGetValue(cb.Name, out items)) return;
            if (cb.Items.Count != items.Length) return;
            cb.Items.Clear();
            cb.Items.AddRange(items);
        }

        static string ConfigPath
        {
            get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MHXXSaveEditor", "language.txt"); }
        }

        // À appeler au démarrage, avant la création de la fenêtre principale.
        public static void Init()
        {
            French = System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "fr";
            try
            {
                if (File.Exists(ConfigPath))
                {
                    string s = File.ReadAllText(ConfigPath).Trim().ToLowerInvariant();
                    if (s == "fr") French = true;
                    else if (s == "en") French = false;
                }
            }
            catch (Exception) { }
            if (French)
            {
                string[] enTypes = (string[])Data.GameConstants.EquipmentTypes.Clone();
                string[] enPalico = (string[])Data.GameConstants.PalicoEquip.Clone();
                Data.FrenchNames.Apply();
                for (int i = 0; i < enTypes.Length; i++) frToEn[Data.GameConstants.EquipmentTypes[i]] = enTypes[i];
                for (int i = 0; i < enPalico.Length; i++) frToEn[Data.GameConstants.PalicoEquip[i]] = enPalico[i];
            }
        }

        static void SaveLanguage(bool french)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(ConfigPath));
                File.WriteAllText(ConfigPath, french ? "fr" : "en");
            }
            catch (Exception) { }
        }

        public static string T(string s)
        {
            if (!French || s == null) return s;
            string r;
            return fr.TryGetValue(s, out r) ? r : s;
        }

        public static string F(string template, params object[] args)
        {
            return string.Format(T(template), args);
        }

        public static DialogResult Show(string text)
        {
            return MessageBox.Show(T(text));
        }

        public static DialogResult Show(string text, string caption)
        {
            return MessageBox.Show(T(text), T(caption));
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return MessageBox.Show(T(text), T(caption), buttons);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(T(text), T(caption), buttons, icon);
        }

        // Traduit les textes d'une fenêtre (contrôles, menus, onglets, colonnes). À appeler après InitializeComponent().
        public static void Apply(Control root)
        {
            if (!French || root == null) return;
            TranslateControl(root);
        }

        static void TranslateControl(Control c)
        {
            string t = T(c.Text);
            if (t != c.Text) c.Text = t;

            ToolStrip strip = c as ToolStrip;
            if (strip != null)
            {
                foreach (ToolStripItem item in strip.Items) TranslateItem(item);
            }

            ComboBox combo = c as ComboBox;
            if (combo != null) TranslateCombo(combo);

            ListView list = c as ListView;
            if (list != null)
            {
                foreach (ColumnHeader h in list.Columns)
                {
                    string ht = T(h.Text);
                    if (ht != h.Text) h.Text = ht;
                }
            }

            foreach (Control child in c.Controls) TranslateControl(child);
        }

        static void TranslateItem(ToolStripItem item)
        {
            string t = T(item.Text);
            if (t != item.Text) item.Text = t;
            ToolStripDropDownItem dd = item as ToolStripDropDownItem;
            if (dd != null)
            {
                foreach (ToolStripItem sub in dd.DropDownItems) TranslateItem(sub);
            }
        }

        // Ajoute le menu « Language / Langue » à la barre de menus.
        public static void AddLanguageMenu(MenuStrip menu)
        {
            ToolStripMenuItem root = new ToolStripMenuItem("Language / Langue");
            ToolStripMenuItem en = new ToolStripMenuItem("English");
            ToolStripMenuItem frItem = new ToolStripMenuItem("Français");
            en.Checked = !French;
            frItem.Checked = French;
            en.Click += delegate { ChangeLanguage(false); };
            frItem.Click += delegate { ChangeLanguage(true); };
            root.DropDownItems.Add(en);
            root.DropDownItems.Add(frItem);
            menu.Items.Add(root);
        }

        static void ChangeLanguage(bool french)
        {
            if (french == French) return;
            string msg = french
                ? "Le programme va redémarrer pour appliquer la langue.\nLes modifications non enregistrées seront perdues."
                : "The program will now restart to apply the language.\nUnsaved changes will be lost.";
            if (MessageBox.Show(msg, "Language / Langue", MessageBoxButtons.OKCancel) != DialogResult.OK) return;
            SaveLanguage(french);
            Application.Restart();
        }
    }
}
