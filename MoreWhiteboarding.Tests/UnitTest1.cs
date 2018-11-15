using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoreWhiteboarding;

namespace MoreWhiteboarding.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Reverse()
        {
            // Arrange
            Reverse r = new Reverse();
            string expected = "esreveR";
            string actual;

            // Act
            actual = r.ReverseString("Reverse");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_An_Int_Array()
        {
            // Arrange
            IntArraySorter s = new IntArraySorter();
            int[] expected = new int[] { 1, 1, 2, 2, 2, 4, 5, 9 };
            int[] input = new int[] { 2, 1, 2, 2, 5, 1, 9, 4 };

            // Act
            int[] actual = s.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Can_Check_Duplicate_Chars_In_String()
        {
            // Arrange
            DupCheck d = new DupCheck();

            // Act
            bool trueCase = d.Check("This string has duplicate chars");
            bool falseCase = d.Check("No duplicates");

            // Assert
            Assert.IsTrue(trueCase);
            Assert.IsFalse(falseCase);
        }

        [TestMethod]
        public void Can_Merge_Int_Arrays()
        {
            // Arrange
            ArrMerger a = new ArrMerger();
            int[][] arr = new int[][] { new int[] { 1, 4, 5 },
                                        new int[] { 2, 6, 9 },
                                        new int[] { 3, 7, 8 }};
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            int[] actual = a.Merge(arr);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Can_Validate_Brackets()
        {
            // Arrange
            BracketValidator b = new BracketValidator();
            bool trueCase;
            bool falseCase;

            // Act
            trueCase = b.Validate("()[]{}([{}])({[]})");
            falseCase = b.Validate("({[)]}");

            // Assert
            Assert.IsTrue(trueCase);
            Assert.IsFalse(falseCase);
        }
    }
}
