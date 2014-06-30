using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using foodme.server.Models;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Http.Cors;

namespace foodme.server.Controllers
{
    public class RestaurantController : ApiController
    {
        Restaurant[] restaurants = null;

        public RestaurantController()
        {
            //Get JSON data from .json file and turn it into a memory stream for JSON deserialization
            string jsonData = System.IO.File.ReadAllText(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath + @"bin\App_Data\restaurants.json");
            byte[] byteArray = Encoding.ASCII.GetBytes(jsonData);
            MemoryStream stream = new MemoryStream(byteArray);

            //deserialize stream to Restaurant objects
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Restaurant[]));
            restaurants = (Restaurant[])(ser.ReadObject(stream));
            foreach(var r in restaurants){
                Console.WriteLine(r.name);
            }            
        }

        // GET api/restaurant
        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return restaurants;
        }

        // GET api/restaurant/5
        public IHttpActionResult GetRestaurant(String id)
        {
            var restaurant = restaurants.FirstOrDefault((r) => r.id == id);
            if (restaurant == null)
            {
                return NotFound();
            }
            return Ok(restaurant);
        }
    }
}
