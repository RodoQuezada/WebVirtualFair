using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebVirtualFair.Helper;
using WebVirtualFair.Models;

namespace WebVirtualFair.Controllers
{
    public class PurchaseOrder : Controller
    {
        UserAPI _api = new UserAPI();
        
        public async Task<IActionResult> PurchaseOrderList(long id)
        {
            var user = new PersonData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/person/{id}");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                user = JsonConvert.DeserializeObject<PersonData>(result);
            }
            
            List<PurchaseOrderData> lista = new List<PurchaseOrderData>();
            lista = user.purchaseOrderDatas;
            
            return View(lista);
        }
        
    }
}