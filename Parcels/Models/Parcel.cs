using System.Collections.Generic;

namespace Parcels.Models
{
    public class Package
    {
        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Weight { get; set; }

        private static List<Package> _instances = new List<Package> { };

        public Package(int height, int length, int width, int weight)
        {
            Height = height;
            Length = length;
            Width = width;
            Weight = weight;
            _instances.Add(this);
        }
        public int GetPrice()
        {
            return Height * Length * Width * Weight / 2;
        }

        public static List<Package> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}