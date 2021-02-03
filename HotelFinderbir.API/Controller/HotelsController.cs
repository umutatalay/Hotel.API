using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelFinderbir.Business.Abstract;
using HotelFinderbir.Business.Concreate;
using HotelFinderbir.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelFinderbir.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelservice;

        public HotelsController()
        {
            _hotelservice = new HotelManager();
        }
        [HttpGet]
        public List<Hotel> Get()
        {
            return _hotelservice.GetAllHotels();
        }


        [HttpGet("{id}")]
        public Hotel Get(int id)
        {
            return _hotelservice.GetHotelById(id);
        }

        [HttpPost]
        public Hotel Post([FromBody]Hotel hotel)
        {
            return _hotelservice.CreateHotel(hotel);
        }

        [HttpPut]
        public Hotel Put([FromBody] Hotel hotel)
        {
            return _hotelservice.UpDataHotel(hotel);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _hotelservice.DeleteHotel(id);  
        }
    }
}
