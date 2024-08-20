using Ibm_Erixson_MobileNetwork.Entites;
using Microsoft.EntityFrameworkCore;

namespace Ibm_Erixson_MobileNetwork.DbConnect
{
    public class HotelRoomContext :DbContext
    {
        public HotelRoomContext()
        {

        }
        public DbSet<Room> rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-OLCB1UC; user id=sa; password=S@12345;Encrypt=True;TrustServerCertificate=True; initial catalog=IbmErixMobileNetwork;");
        }
    }
}
