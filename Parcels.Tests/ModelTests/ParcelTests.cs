using Parcels.Models;

namespace Parcels.Tests
{

    [TestClass]
    public class ParcelTests : IDisposable
    {
        public void Dispose()
        {
            Package.ClearAll();
        }
        [TestMethod]
        public void PackageConstructor_CreatesInstanceOfPackageClass_Package()
        {
            Package package = new(2, 2, 2, 2);
            Assert.AreEqual(typeof(Package), package.GetType());
        }

        [TestMethod]
        public void GetAll_ReturnsListOfPackageObjects_List()
        {
            Package package1 = new(2, 2, 2, 2);
            Package package2 = new(1, 1, 1, 1);
            List<Package> expected = new() { package1, package2 };
            CollectionAssert.AreEqual(expected, Package.GetAll());
        }
        // [TestMethod]
        // public void GetAll_ReturnsListOfPackageObjects()
        // {
        //     Package package1 = new Package(2, 2, 2, 2);
        //     Package package2 = new Package(1, 1, 1, 1);
        //     List<Package> expected = new List<Package> { package1, package2 };
        //     CollectionAssert.AreEqual(expected, Package.GetAll());

        [TestMethod]
        public void GetPrice_ReturnsPriceOfShippingPacakge_Int()
        {
            Package package = new(2, 1, 1, 1);
            int expected = 1;
            Assert.AreEqual(expected, package.GetPrice());
        }
    }



}
