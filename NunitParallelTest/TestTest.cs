using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Timetracker.Tests.DesktopConsoleRunner
{
    [TestFixture]
    public class TestTest
    {
        [Test, Parallelizable]
        public async Task Test1()
        {
            await Task.Delay(1000);
            Assert.IsTrue(true);
        }
        [Test, Parallelizable]
        public async Task Test2()
        {
            await Task.Delay(1200);
            Assert.IsTrue(true);
        }
        [Test, Parallelizable]
        public async Task Test3()
        {
            await Task.Delay(1300);
            Assert.IsTrue(true);
        }
        [Test, Parallelizable]
        public async Task Test4()
        {
            await Task.Delay(1400);
            Assert.IsTrue(true);
        }
        [Test, Parallelizable]
        public async Task Test5()
        {
            await Task.Delay(1500);
            Assert.IsTrue(true);
        }
        [Test, Parallelizable]
        public async Task Test6()
        {
            await Task.Delay(600);
            Assert.IsTrue(true);
        }
        [Test, Parallelizable]
        public async Task Test71()
        {
            await Task.Delay(700);
            Assert.IsTrue(true);
        }
        [Test, Parallelizable]
        public async Task Test8()
        {
            await Task.Delay(800);
            Assert.IsTrue(true);
        }
        [Test, Parallelizable]
        public async Task Test9()
        {
            await Task.Delay(900);
            Assert.IsTrue(true);
        }
        [Test, Parallelizable]
        public async Task Test11()
        {
            await Task.Delay(1000);
            Assert.IsTrue(true);
        }
    }
}
