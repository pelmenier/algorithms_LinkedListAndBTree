using Alg.Model.BTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Alg.Tests
{
    [TestClass]
    public class BTreeTests
    {
        [TestMethod]
        public void BFS()
        {
            //arrange
            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(5);
            tree.Add(5);
            tree.Add(2);
            tree.Add(3);
            tree.Add(7);
            var expected = new List<int>();
            expected.Add(5);
            expected.Add(2);
            expected.Add(5);
            expected.Add(3);
            expected.Add(5);
            expected.Add(7);

            //act            
            var actual = tree.TraverseBFS(tree.Root);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Preorder()
        {
            //arrange
            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(5);
            tree.Add(5);
            tree.Add(2);
            tree.Add(3);
            tree.Add(7);
            var expected = new List<int>();
            expected.Add(5);
            expected.Add(2);
            expected.Add(3);
            expected.Add(5);
            expected.Add(5);
            expected.Add(7);

            //act
            var actual = tree.Preorder();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
