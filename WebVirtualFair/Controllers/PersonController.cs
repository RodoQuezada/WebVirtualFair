using Microsoft.AspNetCore.Mvc;
using WebVirtualFair.Helper;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebVirtualFair.Models;


namespace WebVirtualFair.Controllers
{
    public class PersonController : Controller
    {
    
        UserAPI _api = new UserAPI();
        
        public async Task<IActionResult> List()
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
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonData person)
        {
            HttpClient client = _api.Initial();
            
            

            var postTask = client.PostAsJsonAsync<PersonData>("api/person", person);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("List");
            }
            return View();
        }
        
        public async Task<IActionResult> Delete(long id)
        {
            var user = new PersonData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/person/{id}");
            return RedirectToAction("List");
        }
        
        public async Task<IActionResult> Update(long id)
        {
            var upPerson = new PersonData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync($"api/person/{id}");
            
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                upPerson = JsonConvert.DeserializeObject<PersonData>(result);
            }
            return View(upPerson);
        }
        
        [HttpPost]
        public IActionResult Update(PersonData person)
        {
            if (ModelState.IsValid)
            {
                HttpClient client = _api.Initial();
                var postTask = client.PutAsJsonAsync<PersonData>("api/person/up", person);
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