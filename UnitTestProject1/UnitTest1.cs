using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            User user = new User()
            {
                Name = "dragon.luo"
            };
            var message = @"Created at {user.Name}";
            
            Console.WriteLine(message);
        }
    }

    public class User { public string Name { get; set; } }
}
