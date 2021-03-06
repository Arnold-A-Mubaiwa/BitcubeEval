﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace BitcubeEval.Pages
{
    [Authorize]
    public class FriendModel : PageModel
    {
        private readonly ILogger<FriendModel> _logger;

        public FriendModel(ILogger<FriendModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
