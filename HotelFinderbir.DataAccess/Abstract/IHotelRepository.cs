using HotelFinderbir.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinderbir.DataAccess.Abstract
{
    public interface IHotelRepository
    {
        List<Hotel> GetAllHotels();

        Hotel GetHotelById(int id);

        Hotel CreateHotel(Hotel hotel);

        Hotel UpDataHotel(Hotel hotel);

        void DeleteHotel(int id);



    }
}
