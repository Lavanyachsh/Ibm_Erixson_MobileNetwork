using Ibm_Erixson_MobileNetwork.Entites;
using Microsoft.EntityFrameworkCore;

namespace Ibm_Erixson_MobileNetwork.DbConnect
{
    public class HotelRoomContext :DbContext
    {
        public HotelRoomContext(DbContextOptions<HotelRoomContext> options)
        : base(options)
        {
        }

        public DbSet<Room> rooms { get; set; }
        //        public DbSet<Employee> employees { get; set; }
        //        public DbSet<Dept> depts { get; set; }
        //        public DbSet<order> orders { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"data source=DESKTOP-OLCB1UC; user id=sa; password=S@12345;Encrypt=True;TrustServerCertificate=True; initial catalog=IbmErixMobileNetwork;");
        //}
    }
}

