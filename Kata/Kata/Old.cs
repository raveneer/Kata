using System.Collections.Generic;
using NUnit.Framework;

namespace SolutionOld
{
    [TestFixture]
    public class Kata
    {
        //https://www.codewars.com/kata/57b06f90e298a7b53d000a86/train/csharp
        //슈퍼마켓 큐. 스레드풀과 같은 기능을 구현하는 문제.
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        [TestCase(new[] {1}, 1, 1)]
        [TestCase(new[] {1}, 2, 1)]
        [TestCase(new[] {1, 2}, 2, 2)]
        [TestCase(new[] {1, 2, 3, 4, 5}, 100, 5)]
        [TestCase(new[] {2, 2, 3, 3, 4, 4}, 2, 9)]
        [Test]
        public void Test_QueTime(int[] customerNeededTimes, int processCount, int neededTime)
        {
            Assert.AreEqual(neededTime, QueueTime(customerNeededTimes, processCount));
        }

        public static int QueueTime(int[] customerNeededTimes, int processCount)
        {
            return 0;
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        [TestCase("abC", "A-Bb-Ccc")]
        [Test]
        public void Test_Word(string input, string expected)
        {
            Assert.AreEqual(expected, WordRepeat(input));
        }

        public static string WordRepeat(string input)
        {
            return null;
        }

        [Test]
        public static void Test_CharCount1()
        {
            var d = new Dictionary<char, int>();
            d.Add('a', 4);
            Assert.AreEqual(d, CharCount("aaaa"));
        }

        [Test]
        public static void Test_CharCount2()
        {
            var d = new Dictionary<char, int>();
            d.Add('a', 2);
            d.Add('b', 2);
            Assert.AreEqual(new Dictionary<char, int>(), CharCount(""));
            Assert.AreEqual(d, CharCount("aabb"));
        }

        //https://www.codewars.com/kata/52efefcbcdf57161d4000091/solutions/csharp
        public static Dictionary<char, int> CharCount(string word)
        {
            return null;
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        [Test]
        public void Test_Median()
        {
            Assert.AreEqual(2, Median(new[] {1, 2, 3}));
            Assert.AreEqual(1, Median(new[] {1}));
            Assert.AreEqual(0, Median(new[] {0, 0, 0}));
            Assert.AreEqual(2, Median(new[] {1, 2, 2, 3}));
            Assert.AreEqual(2, Median(new[] {3, 2, 2, 1}));
            Assert.AreEqual(2.5, Median(new[] {3, 3, 2, 2}));
        }

        private double Median(int[] p0)
        {
            return 0;
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        //https://www.codewars.com/kata/57eb8fcdf670e99d9b000272/train/csharp
        //find highest word. a=1, b=2 ...
        [Test]
        public void Test_HighstScore()
        {
            Assert.AreEqual("b", HighestScore("a b"));
            Assert.AreEqual("cc", HighestScore("aa bb cc"));
            Assert.AreEqual("taxi", HighestScore("man i need a taxi up to ubud"));
            Assert.AreEqual("volcano", HighestScore("what time are we climbing up to the volcano"));
        }

        public static string HighestScore(string s)
        {
            return null;
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        //https://www.codewars.com/kata/5277c8a221e209d3f6000b56/solutions/csharp
        //재귀는 스택으로 풀 수 있다.

        [TestFixture]
        public class BraceTests
        {
            [Test]
            public void Test1()
            {
                Assert.AreEqual(true, Brace.ValidBraces("()"));
            }

            [Test]
            public void Test2()
            {
                Assert.AreEqual(false, Brace.ValidBraces("[(])"));
                Assert.AreEqual(true, Brace.ValidBraces("{[()]}"));
                Assert.AreEqual(true, Brace.ValidBraces("{([])}"));
                Assert.AreEqual(true, Brace.ValidBraces("{[]()}"));
                Assert.AreEqual(true, Brace.ValidBraces("[](){}"));
            }
        }

        public class Brace
        {
            public static bool ValidBraces(string braces)
            {
                return false;
            }

            public static bool IsPairBrace(char brace, char compare)
            {
                switch (brace)
                {
                    case '}':
                        return compare == '{';
                    case ']':
                        return compare == '[';
                    case ')':
                        return compare == '(';
                    default:
                        return false;
                }
            }
        }
    }
}