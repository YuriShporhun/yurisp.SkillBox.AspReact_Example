using Application.Tickets.DTO;
using NUnit.Framework;
using System;
using WinClient.NTier.Models;

namespace WinClient.NTier.Tests
{
    [TestFixture]
    public class TripModelTests
    {
        private TripDto correctTripDto;

        [SetUp]
        public void SetUp()
        {
            correctTripDto = new TripDto
            {
                Id = Guid.NewGuid(),
                Departing = DateTime.Now,
                Returning = DateTime.Now.AddDays(1),
                From = "St. Petersburg",
                To = "Moscow"
            };
        }

        [Test]
        public void Ctor_DtoIsNull_ShouldThrowException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Trip trip = new(null);
            });
        }

        [Test]
        public void GetGoingTo_DtoIsCorrect_ShouldPass()
        {
            Trip trip = new (correctTripDto);
            Assert.AreEqual(trip.GoingTo, correctTripDto.To);
        }

        [Test]
        public void GetLeavingFrom_DtoIsCorrect_ShoundPass()
        {
            Trip trip = new(correctTripDto);
            Assert.AreEqual(trip.LeavingFrom, correctTripDto.From);
        }
    }
}
