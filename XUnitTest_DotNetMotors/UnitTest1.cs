using System;
using dot_net_motors.Classes;
using Xunit;

namespace XUnitTest_DotNetMotors
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetPrice()
        {
            // Arrange
            SubaruLegacy subby = new SubaruLegacy();

            // Assert
            Assert.Equal(29000m, subby.Price);
        }

        [Fact]
        public void CanSetPrice()
        {
            // Arrange
            SubaruLegacy subby = new SubaruLegacy();

            // Act
            subby.Price = 29000m;

            // Assert
            Assert.Equal(29000m, subby.Price);

        }

        [Fact]
        public void CanGetNumberOfSeats()
        {
            // Arrange
            SubaruLegacy subby = new SubaruLegacy();

            // Assert
            Assert.Equal(5, subby.NumberOfSeats);

        }

        [Fact]
        public void CanSetNumberOfSeats()
        {
            // Arrange
            SubaruLegacy subby = new SubaruLegacy();

            // Act
            subby.NumberOfSeats = 5;

            // Assert
            Assert.Equal(5, subby.NumberOfSeats);

        }

        [Fact]
        public void CanGetFuelType()
        {
            // Arrange
            SubaruLegacy subby = new SubaruLegacy();
            
            // Assert
            Assert.Equal("gasoline", subby.FuelType);
        }

        [Fact]
        public void CanSetFuelType()
        {
            // Arrange
            SubaruLegacy subby = new SubaruLegacy();

            // Act
            subby.FuelType = "gasoline";

            // Assert
            Assert.Equal("gasoline", subby.FuelType);
        }

        [Fact]
        public void CanGetSunRoof()
        {
            // Arrange
            SubaruLegacy subby = new SubaruLegacy();
            
            // Assert
            Assert.False(subby.SunRoof);
        }

        [Fact]
        public void CanSetSunRoof()
        {
            // Arrange
            SubaruLegacy subby = new SubaruLegacy();

            // Act
            subby.SunRoof = false;

            // Assert
            Assert.False(subby.SunRoof);

        }

        
        
        // Price
        // NumberOfSeats
        // FuelType
        // SunRoof


        // CarriesPeople - bool
        // HaulTrailer - bool
        // GoOffRoading - bool
        // PlayRadio - string

    }
}
