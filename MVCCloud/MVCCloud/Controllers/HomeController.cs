using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCCloud.Models;
using System.Net.Http.Headers;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text;

namespace MVCCloud.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _clientFactory;
        private int orderBy=0;
       public  IEnumerable<Student> students { get; set; }
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        //public async Task<ActionResult> EditStudent(Student st)
        //{
        //    //var request = new HttpRequestMessage(HttpMethod.Post,
        //    // "http://localhost:8080/student/"+st.id);



        //    var client = _clientFactory.CreateClient();
        //    client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/json"));


        //    //Converting the object to a json string. NOTE: Make sure the object doesn't contain circular references.
        //    string json = JsonConvert.SerializeObject(st);

        //    //Needed to setup the body of the request
        //    StringContent data = new StringContent(json, Encoding.UTF8, "application/json");


        //    //  var response = await client.SendAsync(request);
        //    var response = await client.PostAsync(request, data);
        //    var itemStudent = new Student();
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var responseStream = await response.Content.ReadAsStreamAsync();
        //        itemStudent = await JsonSerializer.DeserializeAsync<Student>(responseStream);
        //    }
        //    else
        //    {
        //        itemStudent = new Student();
        //    }


        //    return View(itemStudent);
        //}


        [HttpPost]
        public async Task<ActionResult> GetEditStudent(Student st)
        {
            //var request = new HttpRequestMessage(HttpMethod.Post,
            // "http://localhost:springboot/student/"+st.id);
         
            var request = "http://springboot:8080/student/" + st.id;

            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));


            //Converting the object to a json string. NOTE: Make sure the object doesn't contain circular references.
            string json = JsonConvert.SerializeObject(st);

            //Needed to setup the body of the request
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");


            //  var response = await client.SendAsync(request);
            var response = await client.PutAsync(request, data);
            var itemStudent = new Student();
            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStreamAsync();
                itemStudent = await System.Text.Json.JsonSerializer.DeserializeAsync<Student>(responseStream);
            }
            else
            {
                itemStudent = new Student();
            }


            return View(itemStudent);
        }

        public async Task<ActionResult> GetEditStudent(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
             "http://springboot:8080/student/" + id);

            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.SendAsync(request);
            var itemStudent = new Student();
            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStreamAsync();
                itemStudent = await System.Text.Json.JsonSerializer.DeserializeAsync<Student>(responseStream);
            }
            else
            {
                itemStudent = new Student();
            }


            return View(itemStudent);
        }
        public async Task<ActionResult> DetailStudent(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
             "http://springboot:8080/student/" + id);

            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.SendAsync(request);
            var itemStudent = new Student();
            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStreamAsync();
                itemStudent = await System.Text.Json.JsonSerializer.DeserializeAsync<Student>(responseStream);
            }
            else
            {
                itemStudent = new Student();
            }


            return View(itemStudent);
        }

        [HttpPost, ActionName("AddNewStudent")]
        public async Task<ActionResult> AddNewStudent(Student st)
        {
            //var request = new HttpRequestMessage(HttpMethod.Post,
            // "http://springboot:8080/student/"+st.id);

            var request = "http://springboot:8080/student/";

            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));


            //Converting the object to a json string. NOTE: Make sure the object doesn't contain circular references.
            string json = JsonConvert.SerializeObject(st);

            //Needed to setup the body of the request
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");


            //  var response = await client.SendAsync(request);
            var response = await client.PostAsync(request, data);
            var itemStudent = new Student();
            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStreamAsync();
                itemStudent = await System.Text.Json.JsonSerializer.DeserializeAsync<Student>(responseStream);
            }
            else
            {
                itemStudent = new Student();
            }

         
            // return View(itemStudent);

            return RedirectToAction("Index");
        }


        [HttpPost, ActionName("DeleteStudent")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete,
             "http://springboot:8080/student/" + id);
            //  var request = "http://springboot:8080/student/" + id;
            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            //Converting the object to a json string. NOTE: Make sure the object doesn't contain circular references.
            //string json = JsonConvert.SerializeObject(st);

            ////Needed to setup the body of the request
            //StringContent data = new StringContent(json, Encoding.UTF8, "application/json");


            var response = await client.SendAsync(request);
         //   var itemStudent = new Student();
            if (response.IsSuccessStatusCode)
            {
              //  var responseStream = await response.Content.ReadAsStreamAsync();
              //  itemStudent = await System.Text.Json.JsonSerializer.DeserializeAsync<Student>(responseStream);
            }
            else
            {
               // itemStudent = new Student();
            }

            //return View(itemStudent);
            //   return Redirect("/Home/Index");
            return RedirectToAction("Index");
           // return Redirect("https://google.com");
        }
        [HttpGet, ActionName("AddNewStudent")]
        public ActionResult AddNewStudent()
        {
            return View();
        }

        public HomeController(IHttpClientFactory _clientFactory)
        {
            this._clientFactory = _clientFactory;
        }

        public async Task<IActionResult> Index(int orderBy =0)
        {
            this.orderBy = orderBy;
            var request = new HttpRequestMessage(HttpMethod.Get,
                "http://springboot:8080/student/");

            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStreamAsync();
              students= await System.Text.Json.JsonSerializer.DeserializeAsync<IEnumerable<Student>>(responseStream);
                if(this.orderBy==1)
                {
                    students =  students.OrderByDescending(st => (st.listenning + st.writing, st.reading, st.speaking));
                }   
                else if (this.orderBy ==2)
                {
                    students = students.OrderByDescending(st => (st.year, st.listenning + st.writing, st.reading, st.speaking));
                }
               
            }
            else
            {
                students = new List<Student>();// { name="Thao", listenning=99,writing=1,speaking=22, reading=12});
               
            }

            return View(students);
        }

     


        public IActionResult Privacy()
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
