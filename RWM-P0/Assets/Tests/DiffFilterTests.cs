using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class DiffFilterTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void DiffFilterTestsSimplePasses()
        {
            var testData = new List<int>() { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            var expectedResult = new List<int>() { 4, 2, 6, 5, 6, 5, 6, 5, 6, 5, };

            // Use the Assert class to test conditions
            var result = DiffFilter.Diff(testData);

            Assert.AreEqual(result, expectedResult);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator DiffFilterTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
