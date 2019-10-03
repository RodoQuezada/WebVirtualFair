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
        
        public async Task<IActionResult> listaProsucto()
        {
            List<ProductData> users = new List<ProductData>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/product");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                users = JsonConvert.DeserializeObject<List<ProductData>>(results);
            }
            return View(users);
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

        public ActionResult createProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult createProduct(ProductData product)
        {
            HttpClient client = _api.Initial();

            var postTask = client.PostAsJsonAsync<ProductData>("api/product", product);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("listaProsucto");
            }
            return View();
        }
        
        public async Task<IActionResult> DeleteProduct(long id)
        {
            var user = new ProductData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/product/{id}");
            return RedirectToAction("listaProsucto");
        }

        public async Task<IActionResult> EditProduct(long id)
        {
            var upProduct = new ProductData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync(requestUri: $"api/product/{id}");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                upProduct = JsonConvert.DeserializeObject<ProductData>(result);
                
            }
            return View (upProduct);
        }

        [HttpPost]
        public IActionResult EditProduct(ProductData product)
        {
            if (ModelState.IsValid)
            {
                HttpClient client = _api.Initial();
                var postTAsk = client.PutAsJsonAsync<ProductData>(requestUri: "api/product/up", product);
                postTAsk.Wait();
                var result = postTAsk.Result;
                if(result.IsSuccessStatusCode)
                {
                    return RedirectToAction("listaProsucto");
                }
            }

            return RedirectToAction("listaProsucto");
        }

        //metodos de productos disponibles
        public async Task<IActionResult> listaProductosAvailable()
        {
            List<ProductAvailableData> users = new List<ProductAvailableData>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/productAvailable");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                users = JsonConvert.DeserializeObject<List<ProductAvailableData>>(results);
            }
            return View(users);
        }
        
        public ActionResult createProductAvailable()
        {
            return View();
        }

        [HttpPost]
        public IActionResult createProductAvailable(ProductAvailableData productAvailable)
        {
            HttpClient client = _api.Initial();

            var postTask = client.PostAsJsonAsync<ProductAvailableData>("api/productAvailable", productAvailable);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("listaProductosAvailable");
            }
            return View();
        }
        public async Task<IActionResult> DeleteProductAvailable(long id)
        {
            var user = new ProductAvailableData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync($"api/productAvailable/{id}");
            return RedirectToAction("listaProductosAvailable");
        }
        
        
        
        public async Task<IActionResult> EditProductAvailable(long id)
        {
            var upProductAvailable = new ProductAvailableData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync(requestUri: $"api/productAvailable/{id}");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                upProductAvailable = JsonConvert.DeserializeObject<ProductAvailableData>(result);
                
            }
            return View (upProductAvailable);
        }

        [HttpPost]
        public IActionResult EditProductAvailable(ProductAvailableData productAvailable)
        {
            if (ModelState.IsValid)
            {
                HttpClient client = _api.Initial();
                var postTAsk = client.PutAsJsonAsync<ProductAvailableData>(requestUri: "api/productAvailable/up", productAvailable);
                postTAsk.Wait();
                var result = postTAsk.Result;
                if(result.IsSuccessStatusCode)
                {
                    return RedirectToAction("listaProductosAvailable");
                }
            }

            return RedirectToAction("listaProductosAvailable");
        }


    }
}