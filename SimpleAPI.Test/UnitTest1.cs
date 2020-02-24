using SimpleAPI.Controllers;
using System;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void GetReturnMyName()
        {
            var returnValue = controller.Get(1);

            Assert.Equal("HR", returnValue.Value);
        }
    }
}
