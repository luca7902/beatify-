using MusikPlayer.Models;

public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Beat> Beats { get; set; } // Navigation Property
}