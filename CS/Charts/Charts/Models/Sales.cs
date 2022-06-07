using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charts.Models {
    public class Sales {
        public int Year { get; set; }
        public int Amount { get; set; }
        public string? City { get; set; }

        public static List<Sales> GetSalesList() {
            List<Sales> salesList = new List<Sales>();
            List<string> cities = new List<string>() {
                "New York", "Los Angeles", "Denver"
            };
            int startYear = DateTime.Now.Year;
            Random rand = new Random();

            for (int i = startYear; i > startYear - 10; i--) {
                for (int j = 0; j < cities.Count; j++) {
                    Sales sales = new Sales() { Year = i, Amount = rand.Next(10000, 100000), City = cities[j] };
                    salesList.Add(sales);
                }
            }
            return salesList;
        }
    }
}