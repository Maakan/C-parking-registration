using System;
using System.Collections.Generic;

namespace PM
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Parkings parking = new Parkings(0, "Parking Test 1", "17 boulevard Gaspard Monge", 45.940182, 4.776524, 18);

            //Creation d'une liste de place afin de gerer le nombre de place disponible dans un parking.
            List<Places> places = new List<Places>();

			Places place1 = new Places(parking.id, 45.941200, 4.778135, true);
			Places place2 = new Places(parking.id, 45.941198, 4.778169, true);
			Places place3 = new Places(parking.id, 45.941197, 4.778202, true);
			Places place4 = new Places(parking.id, 45.941195, 4.778236, true);
			Places place5 = new Places(parking.id, 45.941194, 4.778269, true);
			Places place6 = new Places(parking.id, 45.941192, 4.778303, false);
			Places place7 = new Places(parking.id, 45.941190, 4.778336, false);
			Places place8 = new Places(parking.id, 45.941189, 4.778370, false);
			Places place9 = new Places(parking.id, 45.941187, 4.778403, false);
			Places place10 = new Places(parking.id, 45.941114, 4.778401, false);
			Places place11 = new Places(parking.id, 45.941114, 4.778363, false);
			Places place12 = new Places(parking.id, 45.941114, 4.778326, false);
			Places place13 = new Places(parking.id, 45.941113, 4.778288, false);
			Places place14 = new Places(parking.id, 45.941113, 4.778251, false);
			Places place15 = new Places(parking.id, 45.941113, 4.778213, false);
			Places place16 = new Places(parking.id, 45.941113, 4.778138, false);
			Places place17 = new Places(parking.id, 45.941112, 4.778138, false);
			Places place18 = new Places(parking.id, 45.941112, 4.778100, false);
            places.Add(place1);
            places.Add(place2);
            places.Add(place3);
            places.Add(place4);
            places.Add(place5);
            places.Add(place6);
            places.Add(place7);
            places.Add(place8);
            places.Add(place9);
            places.Add(place10);
            places.Add(place11);
            places.Add(place12);
            places.Add(place13);
            places.Add(place14);
            places.Add(place15);
            places.Add(place16);
            places.Add(place17);
            places.Add(place18);

			foreach (Places element in places)
			{
				if (!element.is_busy)
				{
					parking.available_places++;
				}
			}

            Console.WriteLine(parking.available_places+ " places disponible(s) dans le parking " + parking.name + " à l'adresse : " + parking.address);
        }
    }
}
