﻿using System;
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
        
        public async Task<IActionResult> EditPerson(long id)
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
        public IActionResult EditPerson(PersonData person)
        {
            if (ModelState.IsValid)
            {
                HttpClient client = _api.Initial();
                var postTask = client.PutAsJsonAsync<PersonData>("api/person/up", person);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }
        
        
        
        
        // fin funcionalidad Address ///////////////////////////////////////////////////
        public async Task<IActionResult> ListAddress()
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
        
        public ActionResult createAddress()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult createAddress(AddressData addressPar)
        {
            HttpClient client = _api.Initial();

            var postTask = client.PostAsJsonAsync<AddressData>("api/address", addressPar);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("ListAddress");
            }
            return View();
        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteAddress(long id)
        {
            var user = new PersonData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/address/{id}");
            return RedirectToAction("ListAddress");
        }

        public async Task<IActionResult> updateAddress(long id)
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
                      return RedirectToAction("ListAddress");
                  }
            }
            return RedirectToAction("Index");
        }
        
        // fin funcionalidad Address ///////////////////////////////////////////////////
        
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