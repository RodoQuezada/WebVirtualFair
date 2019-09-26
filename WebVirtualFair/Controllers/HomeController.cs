using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebVirtualFair.Helper;
using WebVirtualFair.Models;

namespace WebVirtualFair.Controllers
{
    public class HomeController : Controller
    {
        UserAPI _api = new UserAPI();
        
        public async Task<IActionResult> Index()
        {
            List<PersonData> users = new List<PersonData>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/person");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                users = JsonConvert.DeserializeObject<List<PersonData>>(results);
            }
            return View(users);
        }

        public async Task<IActionResult> Details(long id)
        {
            var user = new PersonData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/person/{id}");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                user = JsonConvert.DeserializeObject<PersonData>(result);
            }

            return View(user);
        }
        
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

        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult create(PersonData person)
        {
            HttpClient client = _api.Initial();

            var postTask = client.PostAsJsonAsync<PersonData>("api/person", person);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        
        
        public async Task<IActionResult> Delete(long id)
        {
            var user = new PersonData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/person/{id}");
            return RedirectToAction("Index");
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

    }
}