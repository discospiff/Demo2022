using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Demo2022.Pages
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
            
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();
            string apiKey = config["apikey"];
            Console.WriteLine(apiKey);
            ViewData["ApiKey"] = apiKey;
        }
    }
}