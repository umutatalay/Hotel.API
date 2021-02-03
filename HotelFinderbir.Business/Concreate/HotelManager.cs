using HotelFinderbir.Business.Abstract;
using HotelFinderbir.DataAccess.Abstract;
using HotelFinderbir.DataAccess.Concreate;
using HotelFinderbir.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinderbir.Business.Concreate
{
    public class HotelManager : IHotelService
    {

        private IHotelRepository _hotelRepository;

        public HotelManager()
        {
            _hotelRepository = new HotelRepository();
        }

        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            _hotelRepository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetHotelById(int id)
        {
            if (id>0)
            {
                return _hotelRepository.GetHotelById(id);
            }
            throw new Exception("ID cannot be less than 1 ");
        }

        public Hotel UpDataHotel(Hotel hotel)
        {
            return _hotelRepository.UpDataHotel(hotel);
        }
    }
}
