using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Models.Db;

namespace MvcStartApp.Controllers
{
    public class LogsController : Controller
    {
        private readonly ILogRepository _repoLog;
        public LogsController(ILogRepository repoLog)
        {
            _repoLog = repoLog;
        }

        public async Task<IActionResult> logs()
        {
            var logs = await _repoLog.GetLogs();
            return View(logs);
        }
    }
}
