using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQCommands
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Car> _Cars = new List<Car>
            {
                new Car{Id=1,BrandID=2,ColorID=2,DailyPrice=500,ModelYear=2015,Description="FOCUS 1.5 TDCI 120 BG"},
                new Car{Id=2,BrandID=3,ColorID=1,DailyPrice=600,ModelYear=2017,Description="Clio 1.5 DCi Touch EDC"},
                new Car{Id=3,BrandID=1,ColorID=3,DailyPrice=900,ModelYear=2020,Description="CLA AMG 200"},
                new Car{Id=4,BrandID=1,ColorID=1,DailyPrice=700,ModelYear=2018,Description="A200 1.4 Style DCT"},
                new Car{Id=5,BrandID=4,ColorID=2,DailyPrice=500,ModelYear=2016,Description="FIORINO 1.3 MultiJet 95 HP"},
            };
            List<Brand> _brands = new List<Brand>
            {
                new Brand{BrandID=1,BrandName="Mercedes"},
                new Brand{BrandID=2,BrandName="Ford"},
                new Brand{BrandID=3,BrandName="Renault"},
                new Brand{BrandID=4,BrandName="Fiat"},
            };

            var joinedTable = from c in _Cars
                           join b in _brands
                           on c.BrandID equals b.BrandID
                           where c.DailyPrice>500 && c.ModelYear>2017
                           select new CarDTO {Id=c.Id,BrandName=b.BrandName, Description=c.Description,DailyPrice=c.DailyPrice,ModelYear=c.ModelYear };

            
            foreach (var car in joinedTable)
            {
                Console.WriteLine($"{car.Description} - Marka: {car.BrandName}");
            }

            
        }
    }
}
