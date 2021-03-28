using Microsoft.VisualStudio.TestTools.UnitTesting;
using tigerRacing_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tigerRacing_project.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            tigerRacing_project.Better bet = new tigerRacing_project.Better();
            if (bet.moveChetah() > 0)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void Form2Test()
        {
            tigerRacing_project.Better bet = new tigerRacing_project.Better();
            if (bet.lastPoint() == 680)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}