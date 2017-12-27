using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matilde.Test
{
    [TestClass]
    public class unit_tests
    {
        [TestMethod]
        public void run()
        {
            true.Should().Be(true);
        }
    }
}
