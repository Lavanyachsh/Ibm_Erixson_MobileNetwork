using Ibm_Erixson_MobileNetwork.DTOS;
using Ibm_Erixson_MobileNetwork.Entites;
using Ibm_Erixson_MobileNetwork.Interfaces;

namespace Ibm_Erixson_MobileNetwork.Services
{
    public class RoomTypeServices : IRoomTypeServices
    {
        IRoomTypeRepositores _rmtrepositores;
        public RoomTypeServices(IRoomTypeRepositores rmtrepositores)
        {
            _rmtrepositores = rmtrepositores;
        }

        public async Task<bool> AddRoomTypes(RoomDto rmdtodetail)
        {
            Room rm = new Room();
            rm.id = rmdtodetail.id;
            rm.price = rmdtodetail.price;
            rm.maxPersons = rmdtodetail.maxPersons;
            rm.vat = rmdtodetail.vat;
            rm.checkOut = rmdtodetail.checkOut;
            rm.checkIn = rmdtodetail.checkIn;
            rm.roomTypeName = rmdtodetail.roomTypeName;
            var res = await _rmtrepositores.AddRoomTypes(rm);
            return res;
        }

        public async  Task<bool> DeleteRoomTypes(int id)
        {
            await _rmtrepositores.DeleteRoomTypes(id);
            return true;
        }

        public async Task<RoomDto> GetAllRoomsById(int id)
        {

            var res = await _rmtrepositores.GetAllRoomsById(id);
            RoomDto rmdto = new RoomDto();
            rmdto.id=res.id;
            rmdto.price = res.price;
            rmdto.checkOut=res.checkOut;
            rmdto.checkIn=res.checkIn;
            rmdto.vat = res.vat;
            rmdto.maxPersons=res.maxPersons;
            rmdto.roomTypeName=res.roomTypeName;
            return rmdto;
        }

        public async Task<List<RoomDto>> GetAllRoomTypes()
        {
            List<RoomDto> lstrmdto = new List<RoomDto>();
            var res = await _rmtrepositores.GetAllRoomTypes();
            foreach (Room rm in res)
            {
                RoomDto rmdto = new RoomDto();
                rmdto.id=rm.id;
                rmdto.price=rm.price;
                rmdto.checkOut = rm.checkOut;
                rmdto.checkIn=rm.checkIn;
                rmdto.vat=rm.vat;
                rmdto.maxPersons = rm.maxPersons;
                rmdto.roomTypeName = rm.roomTypeName;
                lstrmdto.Add(rmdto);

            }
            return lstrmdto;
        }

        public async Task<bool> UpdateRoomTypes(RoomDto rmdtodetail)
        {
           Room rm= new Room();
            rm.id=rmdtodetail.id;
            rm.price=rmdtodetail.price;
            rm.maxPersons=rmdtodetail.maxPersons;
            rm.vat=rmdtodetail.vat;
            rm.checkOut=rmdtodetail.checkOut;
            rm.checkIn=rmdtodetail.checkIn;
            rm.roomTypeName = rmdtodetail.roomTypeName;
            await _rmtrepositores.UpdateRoomTypes(rm);  
            return true;
        }
    }
}
