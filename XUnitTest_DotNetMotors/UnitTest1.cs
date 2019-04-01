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

        [Fact]
        public void CanReturnBoolFromCarriesPeople()
        {
            // Arrange
            ToyotaTacoma tacoma = new ToyotaTacoma();

            // Assert
            Assert.True(tacoma.CarriesPeople);
        }

        [Fact]
        public void CanSemiReturnBoolFromHaulTrailer()
        {
            MackSemi semi = new MackSemi();
            int numOfTrailers = 2;

            Assert.True(semi.HaulTrailer(numOfTrailers));
        }

        [Fact]
        public void CanTacomaReturnBoolFromHaulTrailer()
        {
            ToyotaTacoma tacoma = new ToyotaTacoma();
            int numOfTrailers = 1;
            Assert.True(tacoma.HaulTrailer(numOfTrailers));
        }

        [Fact]
        public void CanReturnBoolFalseFromGoOffRoading()
        {
            MackSemi semi = new MackSemi();
            Assert.False(semi.GoOffRoading());
        }

        [Fact]
        public void CanReturnBoolTrueFromGoOffRoading()
        {
            ToyotaTacoma tacoma = new ToyotaTacoma();
            Assert.True(tacoma.GoOffRoading());
        }

        [Fact]
        public void CanReturnStringFromPlayRadio()
        {
            SubaruLegacy subby = new SubaruLegacy();
            Assert.Equal("Subaru's got tunes", subby.PlayRadio());
        }

        [Fact]
        public void CanTacomaImplementIStartEngine()
        {
            ToyotaTacoma tacoma = new ToyotaTacoma();
            Assert.True(tacoma.PrimeEngine());
        }

        [Fact]
        public void CanSemiImplementIStartEngine()
        {
            MackSemi semi = new MackSemi();
            Assert.True(semi.PrimeEngine());
        }

        [Fact]
        public void CanHondaImplementIStartEngine()
        {
            HondaCrv crv = new HondaCrv();
            Assert.False(crv.PrimeEngine());
        }

        [Fact]
        public void CanVolvoImplementIStartEngine()
        {
            VolvoV70 v70 = new VolvoV70();
            Assert.False(v70.PrimeEngine());
        }

        [Fact]
        public void CanSubaruImplementIStartEngine()
        {
            SubaruLegacy subby = new SubaruLegacy();
            Assert.False(subby.PrimeEngine());
        }

        [Fact]
        public void CanVolvoImplementITransmission()
        {
            VolvoV70 v70 = new VolvoV70();
            Assert.Equal("I, Volvo V70, have a belt-driven transmission.", v70.Transmission());
        }

        [Fact]
        public void CanSubaruImplementITransmission()
        {
            SubaruLegacy subby = new SubaruLegacy();
            Assert.Equal("I have a gear-driven transmission.", subby.Transmission());
        }

    }
}
