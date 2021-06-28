using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomMatTests
    {
        private CustomMath _math;
        //SetUp
        //TearDown
        [SetUp]
        public void SetUp()
        {
            _math = new CustomMath();
        }
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfTheArguments()
        {
            var res = _math.Add(1, 3);

            Assert.That(res, Is.EqualTo(4));
        }

        [Test]
        public void Max_FirstArgIsGreater_ReturnFirstArg()
        {
          
            var result = _math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgIsGreater_SecondFirstArg()
        {
            var result = _math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_ArgsAreSame_ReturnSameArg()
        {
            var result = _math.Max(2, 2);

            Assert.That(result, Is.EqualTo(2));
        }
    }
}
