using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.App.Tests
{
    [TestFixture]
    public class SampleUnitTests
    {
        [Test]
        public void Equality_ShouldMatch()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
