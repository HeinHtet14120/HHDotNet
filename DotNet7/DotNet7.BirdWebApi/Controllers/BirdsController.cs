using System;
using DotNet7.BirdWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DotNet7.BirdWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdsController : ControllerBase
    {

        private readonly string _url = "https://burma-project-ideas.vercel.app/birds";
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            HttpClient client = new HttpClient();
            //var response = await client.GetAsync("Route");
            HttpResponseMessage response = await client.GetAsync(_url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                List<BirdDataModel> birds = JsonConvert.DeserializeObject<List<BirdDataModel>>(json)!;

                //var lst = birds.Select(bird => new BirdViewModel
                //{
                //    Bid = bird.Id,
                //    BirdName = bird.BirdMyanmarName,
                //    BirdImg = bird.ImagePath 
                //});

                List<BirdViewModel> lst = birds.Select(bird => Change(bird)).ToList();

                //List<BirdViewModel> lst2 = new List<BirdViewModel>();

                //foreach(var bird in birds)
                //{
                //    var item = Change(bird);
                //    lst2.Add(item);
                //}
                return Ok(lst);
            }
            else
            {
                Console.WriteLine(response.Content.ReadAsStringAsync());
                return BadRequest();
            }

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            HttpClient client = new HttpClient();
            //var response = await client.GetAsync("Route");
            HttpResponseMessage response = await client.GetAsync($"{_url}/{id}");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                BirdDataModel bird = JsonConvert.DeserializeObject<BirdDataModel>(json)!;

                //var lst = birds.Select(bird => new BirdViewModel
                //{
                //    Bid = bird.Id,
                //    BirdName = bird.BirdMyanmarName,
                //    BirdImg = bird.ImagePath 
                //});

                var item = Change(bird);
                return Ok(item);
            }
            else
            {
                Console.WriteLine(response.Content.ReadAsStringAsync());
                return BadRequest();
            }

        }

        private BirdViewModel Change(BirdDataModel bird)
        {
            BirdViewModel item = new BirdViewModel
            {
                Bid = bird.Id,
                BirdName = bird.BirdMyanmarName,
                BDes = bird.Description,
                BirdImg = $"https://burma-project-ideas.vercel.app/{bird.ImagePath}"
            };

            return item;
        } 

    }
}

