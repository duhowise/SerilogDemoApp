using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SerilogDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("You requested a page!");

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i==56)
                    {
                        throw new System.Exception("This is our demo exception");
                    }
                    else
                    {
                        _logger.LogInformation("The value of i is {loopCountValue}",i);

                    }
                }
            }
            catch (System.Exception exception)
            {

                _logger.LogError("We caught an {exception} on the get call",exception);
            }
        }
    }
}
