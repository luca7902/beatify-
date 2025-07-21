namespace MusikPlayer.Models
{
    public class Beat
    {
        public int Id { get; set; }
        public int Bpm { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }

        public int GenreId { get; set; } // Fremdschlüssel
        public Genre Genre { get; set; } // Navigation Property

        public string Key { get; set; }
        public string MusicPath { get; set; }
        public DateTime AddDate { get; set; }
        public string Duration { get; set; }
    }
}
