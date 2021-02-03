using HotelFinderbir.DataAccess.Abstract;
using HotelFinderbir.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelFinderbir.DataAccess.Concreate
{
    public class HotelRepository : IHotelRepository
    {
        public Hotel CreateHotel(Hotel hotel)
        {
            using (var HotelDbContext = new HotelDbContext())
            {
                HotelDbContext.Hotels.Add(hotel);
                HotelDbContext.SaveChanges();
                return hotel;

            }
        }

        public void DeleteHotel(int id)
        {
            using (var HotelDbContext = new HotelDbContext())
            {
                var DeletedHotel = GetHotelById(id);
                HotelDbContext.Hotels.Remove(DeletedHotel);
                HotelDbContext.SaveChanges();
            }
        }

        public List<Hotel> GetAllHotels()
        {
           using(var HotelDbContext= new HotelDbContext())
            {
                return HotelDbContext.Hotels.ToList();
            }
        }

        public Hotel GetHotelById(int id)
        {
            using (var HotelDbContext = new HotelDbContext())
            {
                return HotelDbContext.Hotels.Find(id);
            }
        }

        public Hotel UpDataHotel(Hotel hotel)
        {
            using (var HotelDbContext = new HotelDbContext())
            {
                HotelDbContext.Hotels.Update(hotel);
                HotelDbContext.SaveChanges();
                return hotel; 
            }
        }
    }
}
