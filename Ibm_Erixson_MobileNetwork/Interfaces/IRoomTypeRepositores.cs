using Ibm_Erixson_MobileNetwork.Entites;
namespace Ibm_Erixson_MobileNetwork.Interfaces
   
{
    public interface IRoomTypeRepositores
    {
        Task<List<Room>> GetAllRoomTypes();
        Task<Room> GetAllRoomsById(int id);
        Task<bool> AddRoomTypes(Room rmdetail);
        Task<bool> DeleteRoomTypes(int id);
        Task<bool> UpdateRoomTypes(Room rmdetail);

    }
    //Task<Room> GetAllRoomsById(int id)
}
