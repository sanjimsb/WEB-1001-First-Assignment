using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WEB1001_Assignment.Pages
{
    public class IntroModel : PageModel
    {
        private readonly ILogger<IntroModel> _logger;

        public IntroModel(ILogger<IntroModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
