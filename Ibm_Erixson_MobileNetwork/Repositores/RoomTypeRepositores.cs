using Ibm_Erixson_MobileNetwork.DbConnect;
using Ibm_Erixson_MobileNetwork.Entites;
using Ibm_Erixson_MobileNetwork.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ibm_Erixson_MobileNetwork.Repositores
{
    public class RoomTypeRepositores : IRoomTypeRepositores
    {
        public HotelRoomContext _hotelrmcontext;
        public RoomTypeRepositores(HotelRoomContext hotelrmcontext)
        {
            this._hotelrmcontext = hotelrmcontext;
        }
        public async Task<bool> AddRoomTypes(Room rmdetail)
        {
            await _hotelrmcontext.rooms.AddAsync(rmdetail);
            _hotelrmcontext.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteRoomTypes(int id)
        {
            Room rm = _hotelrmcontext.rooms.SingleOrDefault(e => e.id == id);
            if (rm != null)
            {
                _hotelrmcontext.rooms.Remove(rm);
                _hotelrmcontext.SaveChanges();
                return true;
            }
            else return false;
        }

        public async Task<Room> GetAllRoomsById(int id)
        {
            Room rm = await _hotelrmcontext.rooms.ToListAsync().Result.FindAll(e => e.id == id);
           Room rm = await _hotelrmcontext.rooms.Where(e => e.id == id).ToListAsync();

            if (rm== null)
                return null;
            else
                return rm;
        }

        public async Task<List<Room>> GetAllRoomTypes()
        {
            var rm = _hotelrmcontext.rooms.ToList();
            if (rm.Count == 0)
                return null;
            else return rm;
        }

        public async Task<bool> UpdateRoomTypes(Room rmdetail)
        {

            await _hotelrmcontext.rooms.Update(rmdetail);
            _hotelrmcontext.SaveChanges();
            return true;
        }
    }
}
