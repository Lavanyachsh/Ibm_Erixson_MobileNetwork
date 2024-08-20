using Ibm_Erixson_MobileNetwork.DTOS;
using Ibm_Erixson_MobileNetwork.Entites;

namespace Ibm_Erixson_MobileNetwork.Interfaces
{
    public interface IRoomTypeServices
    {
        Task<List<RoomDto>> GetAllRoomTypes();
        Task<RoomDto> GetAllRoomsById(int id);
        Task<bool> AddRoomTypes(RoomDto rmdtodetail);
        Task<bool> DeleteRoomTypes(int id);
        Task<bool> UpdateRoomTypes(RoomDto rmdtodetail);
    }
}
