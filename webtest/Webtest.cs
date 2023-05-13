using aspWebapp.Modules;
using Xunit;

namespace webtest
{
    public class Webtest
    {
        [Fact]
        public void Demotest()
        {
            int i = 1;
            bool result = false;
            if (i == 1) result = true;
            Assert.True(result, "The value should be equal to 1");
        }

        [Fact]
        public void CheckAddFunction()
        {
            Functions func = new Functions();
            int y = func.Add(3, 2);

            bool result = false;

            if(y == 5) result = true;
            Assert.True(result, "The value should be 5");
        }
    }
}