using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CubeFilterTest
    {
        [Test]
        public void CubeFilterSimple()
        {
            int[] input = { 1, 3, 5, 7, 9, 999, 5 };
            int[] output = CubeFilter.cubes(input);
            int[] expected = { 1, 27, 125, 343, 729, 997002999, 125 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

