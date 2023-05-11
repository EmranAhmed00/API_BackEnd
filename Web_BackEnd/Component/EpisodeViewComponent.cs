using Microsoft.AspNetCore.Mvc;
using Web_BackEnd.Services;

namespace Web_BackEnd.Component
{
    public class EpisodeViewComponent : ViewComponent
    {
        private IEpisodeService _episodeService;
        public EpisodeViewComponent(IEpisodeService episodeService)
        {
            _episodeService = episodeService;
        }

        public async Task<IViewComponentResult> InvokeAsync(long id)
        {
            var list = await _episodeService.GetLatestThreeEpisodes(id);
            return View(list);
        }

    }
}
