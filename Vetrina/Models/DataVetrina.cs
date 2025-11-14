using System.Text.Json;

namespace Vetrina.Models
{
    public class DataVetrina
    {
        private static string filePath = "ProductsNew.json";
        public static List<ProductType> Products = LoadProducts();

        //SAVE
        public static void SaveProduct()
        {
            var json = JsonSerializer.Serialize(Products);
            File.WriteAllText(filePath, json);
        }

        //LOAD
        private static List<ProductType> LoadProducts()
        {
            if (!File.Exists(filePath)) return new List<ProductType>();

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<ProductType>>(json) ?? new List<ProductType>();
        }
    }
}
