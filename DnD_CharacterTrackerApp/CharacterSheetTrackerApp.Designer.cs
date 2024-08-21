namespace DnD_CharacterTrackerApp {
    partial class CharacterSheetTrackerApp {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            TextBox creationDateField;
            DateTimePicker endDateTimePicker;
            TextBox endDateField;
            saveCharacterBtn = new Button();
            nameField = new TextBox();
            raceField = new TextBox();
            classField = new TextBox();
            ageField = new TextBox();
            heightField = new TextBox();
            armorClassField = new TextBox();
            healthPointsField = new TextBox();
            creationDateTimePicker = new DateTimePicker();
            characterListView = new ListBox();
            characterListLabel = new Label();
            basicStatsLabel = new Label();
            subClassField = new TextBox();
            loadCharactersBtn = new Button();
            creationDateField = new TextBox();
            endDateTimePicker = new DateTimePicker();
            endDateField = new TextBox();
            SuspendLayout();
            // 
            // creationDateField
            // 
            creationDateField.Location = new Point(14, 370);
            creationDateField.Name = "creationDateField";
            creationDateField.ReadOnly = true;
            creationDateField.Size = new Size(100, 27);
            creationDateField.TabIndex = 3;
            creationDateField.Text = "Creation Date";
            creationDateField.TextAlign = HorizontalAlignment.Center;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(124, 403);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(210, 27);
            endDateTimePicker.TabIndex = 2;
            // 
            // endDateField
            // 
            endDateField.Location = new Point(14, 403);
            endDateField.Name = "endDateField";
            endDateField.ReadOnly = true;
            endDateField.Size = new Size(100, 27);
            endDateField.TabIndex = 3;
            endDateField.Text = "End Date";
            endDateField.TextAlign = HorizontalAlignment.Center;
            // 
            // saveCharacterBtn
            // 
            saveCharacterBtn.Location = new Point(80, 445);
            saveCharacterBtn.Name = "saveCharacterBtn";
            saveCharacterBtn.Size = new Size(164, 23);
            saveCharacterBtn.TabIndex = 0;
            saveCharacterBtn.Text = "Save Character";
            saveCharacterBtn.UseVisualStyleBackColor = true;
            saveCharacterBtn.Click += OnSaveCharacterButtonClick;
            // 
            // nameField
            // 
            nameField.BackColor = SystemColors.Info;
            nameField.Location = new Point(14, 76);
            nameField.Margin = new Padding(5);
            nameField.Name = "nameField";
            nameField.Size = new Size(320, 27);
            nameField.TabIndex = 1;
            // 
            // raceField
            // 
            raceField.BackColor = SystemColors.Info;
            raceField.Location = new Point(14, 113);
            raceField.Margin = new Padding(5);
            raceField.Name = "raceField";
            raceField.Size = new Size(320, 27);
            raceField.TabIndex = 1;
            // 
            // classField
            // 
            classField.BackColor = SystemColors.Info;
            classField.Location = new Point(14, 150);
            classField.Margin = new Padding(5);
            classField.Name = "classField";
            classField.Size = new Size(320, 27);
            classField.TabIndex = 1;
            // 
            // ageField
            // 
            ageField.BackColor = SystemColors.Info;
            ageField.Location = new Point(14, 224);
            ageField.Margin = new Padding(5);
            ageField.Name = "ageField";
            ageField.Size = new Size(320, 27);
            ageField.TabIndex = 1;
            // 
            // heightField
            // 
            heightField.BackColor = SystemColors.Info;
            heightField.Location = new Point(14, 261);
            heightField.Margin = new Padding(5);
            heightField.Name = "heightField";
            heightField.Size = new Size(320, 27);
            heightField.TabIndex = 1;
            // 
            // armorClassField
            // 
            armorClassField.BackColor = SystemColors.Info;
            armorClassField.Location = new Point(14, 298);
            armorClassField.Margin = new Padding(5);
            armorClassField.Name = "armorClassField";
            armorClassField.Size = new Size(320, 27);
            armorClassField.TabIndex = 1;
            // 
            // healthPointsField
            // 
            healthPointsField.BackColor = SystemColors.Info;
            healthPointsField.Location = new Point(14, 335);
            healthPointsField.Margin = new Padding(5);
            healthPointsField.Name = "healthPointsField";
            healthPointsField.Size = new Size(320, 27);
            healthPointsField.TabIndex = 1;
            // 
            // creationDateTimePicker
            // 
            creationDateTimePicker.Location = new Point(124, 370);
            creationDateTimePicker.Name = "creationDateTimePicker";
            creationDateTimePicker.Size = new Size(210, 27);
            creationDateTimePicker.TabIndex = 2;
            // 
            // characterListView
            // 
            characterListView.FormattingEnabled = true;
            characterListView.Location = new Point(536, 74);
            characterListView.Name = "characterListView";
            characterListView.Size = new Size(252, 340);
            characterListView.TabIndex = 4;
            // 
            // characterListLabel
            // 
            characterListLabel.AutoSize = true;
            characterListLabel.Font = new Font("Yu Gothic", 25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 161);
            characterListLabel.ForeColor = Color.Chocolate;
            characterListLabel.Location = new Point(536, 21);
            characterListLabel.MinimumSize = new Size(100, 50);
            characterListLabel.Name = "characterListLabel";
            characterListLabel.Size = new Size(254, 50);
            characterListLabel.TabIndex = 5;
            characterListLabel.Text = "Character List";
            characterListLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // basicStatsLabel
            // 
            basicStatsLabel.AutoSize = true;
            basicStatsLabel.Font = new Font("Yu Gothic", 25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 161);
            basicStatsLabel.ForeColor = Color.Chocolate;
            basicStatsLabel.Location = new Point(71, 21);
            basicStatsLabel.MinimumSize = new Size(100, 50);
            basicStatsLabel.Name = "basicStatsLabel";
            basicStatsLabel.Size = new Size(206, 50);
            basicStatsLabel.TabIndex = 5;
            basicStatsLabel.Text = "Basic Stats";
            basicStatsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subClassField
            // 
            subClassField.BackColor = SystemColors.Info;
            subClassField.Location = new Point(14, 187);
            subClassField.Margin = new Padding(5);
            subClassField.Name = "subClassField";
            subClassField.Size = new Size(320, 27);
            subClassField.TabIndex = 1;
            // 
            // loadCharactersBtn
            // 
            loadCharactersBtn.Location = new Point(587, 445);
            loadCharactersBtn.Name = "loadCharactersBtn";
            loadCharactersBtn.Size = new Size(164, 23);
            loadCharactersBtn.TabIndex = 0;
            loadCharactersBtn.Text = "Load Characters";
            loadCharactersBtn.UseVisualStyleBackColor = true;
            loadCharactersBtn.Click += OnLoadCharactersBtnClick;
            // 
            // CharacterSheetTrackerApp
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 480);
            Controls.Add(basicStatsLabel);
            Controls.Add(characterListLabel);
            Controls.Add(characterListView);
            Controls.Add(endDateField);
            Controls.Add(creationDateField);
            Controls.Add(endDateTimePicker);
            Controls.Add(creationDateTimePicker);
            Controls.Add(healthPointsField);
            Controls.Add(armorClassField);
            Controls.Add(heightField);
            Controls.Add(ageField);
            Controls.Add(subClassField);
            Controls.Add(classField);
            Controls.Add(raceField);
            Controls.Add(nameField);
            Controls.Add(loadCharactersBtn);
            Controls.Add(saveCharacterBtn);
            Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 161);
            Name = "CharacterSheetTrackerApp";
            Text = "D&D Character Tracker App";
            Load += CharacterSheetTrackerApp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveCharacterBtn;
        private TextBox nameField;
        private TextBox raceField;
        private TextBox classField;
        private TextBox ageField;
        private TextBox heightField;
        private TextBox armorClassField;
        private TextBox healthPointsField;
        private DateTimePicker creationDateTimePicker;
        private TextBox creationDateField;
        private DateTimePicker endDateTimePicker;
        private TextBox endDateField;
        private ListBox characterListView;
        private Label characterListLabel;
        private Label basicStatsLabel;
        private TextBox subClassField;
        private Button loadCharactersBtn;
    }
}
