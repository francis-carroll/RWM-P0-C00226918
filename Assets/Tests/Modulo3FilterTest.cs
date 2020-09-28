using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Modulo3FilterTest
    {
        [Test]
        public void Modulo3FilterTestSimple()
        {
            int[] input = { 7, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] expected = Modulo3Filter.modulo3s(input);
            int[] output = { 1, 2, 2, 0, 0, 1, 1, 2, 2, 0 };

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void Modulo3FilterTestIntermediate()
        {
            int[] input = { 0, 1220, -20 };
            int[] expected = Modulo3Filter.modulo3s(input);
            int[] output = { 0, 2, -2};

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
