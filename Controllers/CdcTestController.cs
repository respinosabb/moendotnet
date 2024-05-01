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


    https://accounts.us1.gigya.com/accounts.getScreenSets?screenSetIDs=Moen-ProfileUpdate&include=html%2Ccss%2Cjavascript%2Ctranslations%2C&lang=en&APIKey=4_f-M18WU1TJjgxNP7oKizbw&source=showScreenSet&sdk=js_latest&pageURL=https%3A%2F%2Fwww.moen.com%2F&sdkBuild=15877&format=json&httpStatusCodes=true

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
