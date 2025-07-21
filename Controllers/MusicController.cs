using Microsoft.AspNetCore.Mvc;
using MusikPlayer.Data.Service;

public class MusicController : Controller
{
    private readonly BeatService _beatService;

    public MusicController(BeatService beatService)
    {
        _beatService = beatService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> GetBeats()
    {
        var beatListe = await _beatService.GetAllBeatsAsync();
        return Json(beatListe);
    }
}
