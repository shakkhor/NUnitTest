﻿
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange 
            var reservation = new Reservation();

            //Act 
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);

        }
       

        [Test]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsFalse()
        {
            var user = new User();
            var reservation = new Reservation() { MadeBy = user};          
                       
            var result = reservation.CanBeCancelledBy(user);
      
            Assert.IsTrue(result);

        }


        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse()
        {
            var user = new User();
            var reservation = new Reservation() { MadeBy = user };
            var otherUser = new User();

            var result = reservation.CanBeCancelledBy(otherUser);

            Assert.IsFalse(result);

        }
    }
}
