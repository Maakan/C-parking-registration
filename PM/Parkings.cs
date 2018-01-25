using System;

namespace PM
{
    public class Parkings
	{
        
		public int id { get; private set; }
		public string name { get; private set; }
        public string address { get; private set; }
        public double latitude { get; private set; }
        public double longitude { get; private set; }
        public int capacity { get;private set; }
        public int available_places { get; set; }


		//Constructeur avec paramètres de la classe Parking
		public Parkings(int parking_id, string parking_name, string parking_address, double parking_latitude, double parking_longitute, int parking_capacity)
		{
            id = parking_id;
			name = parking_name  ;
			address = parking_address ;
			latitude = parking_latitude ;
			longitude = parking_longitute  ;
			capacity = parking_capacity  ;

		
		}
		
	}
}
