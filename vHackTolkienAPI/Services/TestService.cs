using vHackTolkienAPI.Models;

namespace vHackTolkienAPI.Services
{
    public class TestService : ITestService
    {
        private readonly IDbService _dbService;
        public TestService(IDbService dbService)
        {
            _dbService = dbService;
        }
        public async Task<bool> CreateTest(Test test)
        {
            var result =
                await _dbService.EditData(
                    "INSERT INTO public.testtable(Name) VALUES (@name)",
                    test);
            return true;
        }
    }
}
