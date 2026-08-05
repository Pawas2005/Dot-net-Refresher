using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace BikeRentalAssignment;

public class BikeUtility
{
    private SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();

    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        Bike bike = new Bike
        {
            Model = model,
            Brand = brand,
            PricePerDay = pricePerDay
        };
        bikeDetails.Add(bikeDetails.Count + 1, bike);
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> res = new SortedDictionary<string, List<Bike>>();

        foreach(var item in bikeDetails)
        {
            Bike bike = item.Value;

            if(!res.ContainsKey(bike.Brand))
            {
                res.Add(bike.Brand, new List<Bike>());
            }
            res[bike.Brand].Add(bike);
        }

        return res;
    }
}