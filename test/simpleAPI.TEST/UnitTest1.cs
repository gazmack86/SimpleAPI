using System;
using Xunit;
using SimpleAPI.Controllers;

namespace simpleAPI.TEST
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Gareth MacKinnon", returnValue.Value);
        }
        
        
        [Fact]
        public void Test1() 
        {

        }
    }
}
