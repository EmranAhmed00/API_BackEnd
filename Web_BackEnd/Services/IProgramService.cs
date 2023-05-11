using Newtonsoft.Json;
using Web_BackEnd.Models;

namespace Web_BackEnd.Services
{
    public interface IProgramService
    {
        public Task<List<ProgramViewModel>?> GetHumorPrograms();
        public Task<List<ProgramViewModel>?> GetPrograms();

        public Task<List<ProgramViewModel>?> GetHavePodcastsPrograms();

        public Task<List<ProgramViewModel>?> GetNoArchivedPrograms();

    }
}
