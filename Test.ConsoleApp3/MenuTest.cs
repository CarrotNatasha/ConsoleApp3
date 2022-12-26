using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3;
using ConsoleApp3.MenuF;

namespace Test.ConsoleApp3
{
    [TestFixture]
    public class MenuTest
    {
        [Test]
        public void Menu_ManageItems()
        {
            Menu.Clear();

            Menu.AddItem(new MenuExit());
            Assert.AreEqual(1, Menu.ItemsCount);

            Menu.Clear();
            Assert.AreEqual(0, Menu.ItemsCount);
        }
    }
}
