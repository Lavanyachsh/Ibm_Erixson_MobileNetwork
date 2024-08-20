using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ibm_Erixson_MobileNetwork.Entites
{
    public class Room
    {
        public int id {  get; set; }
        public string roomTypeName { get; set; }
        public int price { get; set; }
        public int vat { get; set; }
        public int maxPersons { get; set; }
        public string checkOut { get; set; }
        public string checkIn {  get; set; }
    }
}

/*id: number;
roomTypeName: string;
price: number;
vat: number;
maxPersons: number;
checkIn: string;
checkOut: string;*/