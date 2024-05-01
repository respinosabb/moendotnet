using Microsoft.AspNetCore.Mvc;
using MoenDotNet.Models;
using System.Diagnostics;

namespace MoenDotNet.Controllers
{
    /*

    # CDC Test Login Page
    CDC API Key | 4_WaSna4VYLJEXpgg_JEGwiA
    Registration/Login ScreenSet ID:  Moen-RegistrationLogin

    Load Web SDK
    https://help.sap.com/docs/SAP_CUSTOMER_DATA_CLOUD/8b8d6fffe113457094a17701f63e3d6a/417f1e0c70b21014bbc5a10ce4041860.html

    Accounts.getScreenSets JS
    https://help.sap.com/docs/SAP_CUSTOMER_DATA_CLOUD/8b8d6fffe113457094a17701f63e3d6a/4135fb5270b21014bbc5a10ce4041860.html


    TODO: 
    - Put the API key in appsettings
    - Put the screenset ID in constants or app settings
    - Move all this to Shopify
    */


    public class CdcTestController : Controller
    {
        private readonly ILogger<CdcTestController> _logger;

        public CdcTestController(ILogger<CdcTestController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
