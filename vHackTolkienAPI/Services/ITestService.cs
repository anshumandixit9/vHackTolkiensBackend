using vHackTolkienAPI.Models;

namespace vHackTolkienAPI.Services
{
    public interface ITestService
    {
        Task<bool> CreateTest(Test test);
    }
}
