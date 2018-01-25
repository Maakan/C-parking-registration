using System;
namespace PM
{
    public class Places
	{

		public static int id_counter;
		public int id { get; private set; }
		public int parking_id { get; private set; }
		public double latitude { get; private set; }
		public double longitude { get; private set; }
		public bool is_busy { get; private set; }

		public Places(int place_p_id, double place_latitude, double place_longitude, bool place_is_busy)
		{
			id = id_counter++;
			parking_id = place_p_id ;
			latitude = place_latitude ;
			longitude = place_longitude  ;
			is_busy = place_is_busy ;

		}
	}

}
