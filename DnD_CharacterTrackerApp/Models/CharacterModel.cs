namespace DnD_CharacterTrackerApp.Models {
    public  class CharacterModel {
        public string? Name { get; set; }
        public string? Race { get; set; }
        public string? Class { get; set; }
        public string SubClass { get; set; } = "None";
        public int? Age { get; set; }
        public float? Height { get; set; }
        public int? AC { get; set; }
        public int? HP { get; set; }
        public string? CreationDate { set; get; }
        public string? EndDate {  set; get; }
    }
}
