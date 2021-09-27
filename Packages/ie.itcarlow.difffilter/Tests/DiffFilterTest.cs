using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class diffFilterTest
    {
        [Test]
        public void DiffFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6, 25};
            int[] output = DiffFilter.diffs(input);
            int[] expected = { 4, 2, 6, 5, 6, 5, 6, 5, 6, 5, 19};

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

