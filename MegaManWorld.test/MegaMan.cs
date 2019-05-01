using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adventure;
using System;

namespace Adventure.Tests
{

  [TestClass]
  public class TestAddItems
  {
    [TestMethod]
    public void TestAddItemsToBag()
    {
      Bag bag = new Bag();
      bag.AddItem(Listof_Items.LongSword, 1);
      Assert.AreEqual(1, bag.CheckForItem(Listof_Items.LongSword));
    }
    
}
