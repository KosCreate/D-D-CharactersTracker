using DnD_CharacterTrackerApp.DBConnection;
using DnD_CharacterTrackerApp.Models;

namespace DnD_CharacterTrackerApp {
    public partial class CharacterSheetTrackerApp : Form {
        private List<CharacterModel> _charactersCreated = new List<CharacterModel>();

        public CharacterSheetTrackerApp() {
            InitializeComponent();
            LoadCharacters(); 
        }

        private void CharacterSheetTrackerApp_Load(object sender, EventArgs e) {

        }

        private void LoadCharacters() {
            _charactersCreated = SqliteDataAccess.LoadCharacters()!;
            UpdateListView();
        }

        private void SavePerson() {
            CharacterModel characterModel = new CharacterModel() {
                Name = nameField.Text,
                Race = raceField.Text,
                Class = classField.Text,
                SubClass = subClassField.Text,
                Age = int.Parse(ageField.Text),
                Height = float.Parse(healthPointsField.Text), 
                AC = int.Parse(armorClassField.Text),
                HP = int.Parse(healthPointsField.Text),
            };

            SqliteDataAccess.SaveCharacter(characterModel);

            LoadCharacters();
        }

        private void OnSaveCharacterButtonClick(object sender, EventArgs e) {
            SavePerson();
        }

        private void OnLoadCharactersBtnClick(object sender, EventArgs e) {
            LoadCharacters();
        }

        private void UpdateListView() {
            characterListView.DataSource = null;
            characterListView.DataSource = _charactersCreated;
            characterListView.DisplayMember = "Name";
        }

        private void ClearAllFields() {

        }
    }
}
