using CITestNetCore.Models;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CITestNetCore.UnitTests
{
    public class CategoryTest
    {
        
        [Test]
        public void IsValidCategory()
        {
            //Arrange
            var testCategory = new Category() { idCategory = 1, name = "Test1", description = "Test1" };
            //var testCategory = new Category() { idCategory = 1, description = "Test1" };

            //Act
            var context = new ValidationContext(testCategory, null, null);
            var results = new List<ValidationResult>();
            var isModelStateValid = Validator.TryValidateObject(testCategory, context, results, true);

            // Assert
            Assert.IsTrue(isModelStateValid, results.Count > 0 ? results.FirstOrDefault().ErrorMessage : "");
        }

    }
}