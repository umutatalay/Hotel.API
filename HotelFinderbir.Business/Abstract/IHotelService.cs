using HotelFinderbir.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinderbir.Business.Abstract
{
    public interface IHotelService
    {
        List<Hotel> GetAllHotels();

        Hotel GetHotelById(int id);

        Hotel CreateHotel(Hotel hotel);

        Hotel UpDataHotel(Hotel hotel);

        void DeleteHotel(int id);


    }
}
