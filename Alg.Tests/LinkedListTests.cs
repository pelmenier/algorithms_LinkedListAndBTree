using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alg.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void Swap_1on4()
        {
            //arrange
            int index = 1;
            int replace = 4;
            int expected = 4;
            Model.LinkedList<int> list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            //act            
            var actual = list.UpdateItem(index, replace);          

            //assert
            Assert.AreEqual(expected, actual.Data);
        }

        [TestMethod]
        public void FirstList_Union_SecondList()
        {
            //arrange
            Model.LinkedList<int> firstList = new Model.LinkedList<int>();
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(3);
            Model.LinkedList<int> secondList = new Model.LinkedList<int>();
            secondList.Add(1);
            secondList.Add(2);
            secondList.Add(3);            

            int expected = firstList.Count + secondList.Count;

            //act
            firstList.UnionLinkedList(secondList);
            int actual = firstList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
