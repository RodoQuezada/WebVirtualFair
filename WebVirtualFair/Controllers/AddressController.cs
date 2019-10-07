using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebVirtualFair.Helper;
using WebVirtualFair.Models;

namespace WebVirtualFair.Controllers
{
    public class AddressController : Controller
    {
        
        UserAPI _api = new UserAPI();
        
        
        
        public async Task<IActionResult> List()
        {
            List<AddressData> users = new List<AddressData>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/address");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                users = JsonConvert.DeserializeObject<List<AddressData>>(results);
            }
            return View(users);
        }
        
            
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(AddressData addressPar)
        {
            HttpClient client = _api.Initial();

            var postTask = client.PostAsJsonAsync<AddressData>("api/address", addressPar);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("List");
            }
            return View();
        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteAddress(long id)
        {
            var user = new PersonData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/address/{id}");
            return RedirectToAction("List");
        }

        public async Task<IActionResult> Update(long id)
        {
            var upAddress = new AddressData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/address/{id}");
            
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                upAddress = JsonConvert.DeserializeObject<AddressData>(result);
            }
            return View(upAddress);
        }

        
        [HttpPost]
        public IActionResult updateAddress(AddressData addressUp)
        {
            if (ModelState.IsValid)
            {
                 HttpClient client = _api.Initial();
                 var postTask = client.PutAsJsonAsync<AddressData>("api/address/up", addressUp);
                  postTask.Wait();
                  var result = postTask.Result;
                  if (result.IsSuccessStatusCode)
                  {
                      return RedirectToAction("List");
                  }
            }
            return RedirectToAction("List");
        }
        
    }
}