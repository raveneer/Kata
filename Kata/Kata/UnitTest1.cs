using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Solution
{
    [TestFixture]
    public class Kata
    {
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

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        //https://www.codewars.com/kata/566fc12495810954b1000030/train/csharp
        //n을 받아서 0에서 n까지 각 수마다 제곱하여 숫자들을 만들라. (ex number =3 => (0, 1,4,9))
        //그리고 그 숫자들에서 k 라는 숫자가 몇번이나 나오는지 반환할 것. (11은 1이 2개이고 12는 1이 1개이다 라는 식)
        [TestFixture]
        public static class NbDigTests
        {
            private static void testing(int actual, int expected)
            {
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public static void test1()
            {
                Console.WriteLine("Fixed Tests NbDig");
                testing(CountDig.NbDig(5750, 0), 4700);
                testing(CountDig.NbDig(11011, 2), 9481);
                testing(CountDig.NbDig(12224, 8), 7733);
                testing(CountDig.NbDig(11549, 1), 11905);
            }
        }

        public class CountDig
        {
            public static int NbDig(int n, int d)
            {
                return 0;
            }
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        //https://www.codewars.com/kata/58f5c63f1e26ecda7e000029/train/csharp
        //글자가 파도치게 하라.

        [TestFixture]
        private class KataTestClass
        {
            [TestCase]
            public void BasicTest1()
            {
                var kata = new Kata();
                var result = new List<string> {"Hello", "hEllo", "heLlo", "helLo", "hellO"};
                Assert.AreEqual(result, kata.wave("hello"), "it should return '" + result + "'");
            }

            [TestCase]
            public void BasicTest2()
            {
                var kata = new Kata();
                var result = new List<string> {"Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS"};
                Assert.AreEqual(result, kata.wave("codewars"), "it should return '" + result + "'");
            }

            [TestCase]
            public void BasicTest3()
            {
                var kata = new Kata();
                var result = new List<string>();
                Assert.AreEqual(result, kata.wave(""), "it should return '" + result + "'");
            }

            [TestCase]
            public void BasicTest4()
            {
                var kata = new Kata();
                var result = new List<string> {"Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS"};
                Assert.AreEqual(result, kata.wave("two words"), "it should return '" + result + "'");
            }

            [TestCase]
            public void BasicTest5()
            {
                var kata = new Kata();
                var result = new List<string> {" Gap ", " gAp ", " gaP "};
                Assert.AreEqual(result, kata.wave(" gap "), "it should return '" + result + "'");
            }
        }

        public List<string> wave(string str)
        {
            return null;
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        //공을 x 높이에서 떨어뜨린다. 공의 탄성이 y 이고 z 높이에서 관측할 때, 공은 몇번 관측되는가?
        //떨어질때와 올라올때 각각 1회씩의 관측임.
        //https://www.codewars.com/kata/bouncing-balls/train/csharp

        [TestFixture]
        public class BouncingBallTests
        {
            [Test]
            public void Test1()
            {
                Assert.AreEqual(3, BouncingBall.bouncingBall(3.0, 0.66, 1.5));
            }

            [Test]
            public void Test2()
            {
                Assert.AreEqual(15, BouncingBall.bouncingBall(30.0, 0.66, 1.5));
            }
        }

        public class BouncingBall
        {
            public static int bouncingBall(double h, double bounce, double window)
            {
                return 0;
            }
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        //1차 방정식 풀기.
        //bx = ax +c.
        //결과를 시.분.초로 표시하시오.
        //https://www.codewars.com/kata/tortoise-racing/train/csharp

        [TestFixture]
        public class TortoiseTests
        {
            [Test]
            public void Test1()
            {
                Console.WriteLine("****** Basic Tests");
                Assert.AreEqual(new[] {0, 32, 18}, Tortoise.Race(720, 850, 70));
                Assert.AreEqual(new[] {3, 21, 49}, Tortoise.Race(80, 91, 37));
                Assert.AreEqual(new[] {2, 0, 0}, Tortoise.Race(80, 100, 40));
            }
        }

        public class Tortoise
        {
            public static int[] Race(int v1, int v2, int g)
            {
                return null;
            }
        }

        //https://www.codewars.com/kata/build-tower/train/csharp
        //build Tower!
        /*
        [
        '  *  ',
        ' *** ',
        '*****'
        ]
        [
        '     *     ',
        '    ***    ',
        '   *****   ',
        '  *******  ',
        ' ********* ',
        '***********'
        ]
        */

        [TestFixture]
        public class KataTests
        {
            [Test]
            public void BasicTests()
            {
                Assert.AreEqual(string.Join(",", " * ", "***"), string.Join(",", TowerBuilder(2)));
                Assert.AreEqual(string.Join(",", "*"), string.Join(",", TowerBuilder(1)));
                Assert.AreEqual(string.Join(",", "  *  ", " *** ", "*****"), string.Join(",", TowerBuilder(3)));
            }
        }

        public static string[] TowerBuilder(int nFloors)
        {
            return null;
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        //공을 km/h 로 위로 던진다. 0.1초 마다 체크할 때, 몇 체크 만에 최고점에 이르는가? (중력가속도는 9.81이다)
        //https://www.codewars.com/kata/ball-upwards/train/csharp

        [TestFixture]
        public static class BallTests
        {
            private static void testing(int actual, int expected)
            {
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public static void test1()
            {
                testing(Ball.MaxBall(37), 10);
                testing(Ball.MaxBall(45), 13);
                testing(Ball.MaxBall(99), 28);
                testing(Ball.MaxBall(85), 24);
            }
        }

        public class Ball
        {
            public static int MaxBall(int v0)
            {
                return 0;
            }
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        //https://www.codewars.com/kata/578aa45ee9fd15ff4600090d
        /*
           You have an array of numbers.
           Your task is to sort ascending odd numbers but even numbers must be on their places.
           Zero isn't an odd number and you don't need to move it. If you have an empty array, you need to return it.
        */

        [Test]
        public void Test_SortArray()
        {
            Assert.AreEqual(new[] {1, 3, 2, 8, 5, 4}, SortArray(new[] {5, 3, 2, 8, 1, 4}));
            Assert.AreEqual(new[] {1, 3, 5, 8, 0}, SortArray(new[] {5, 3, 1, 8, 0}));
            Assert.AreEqual(new int[] { }, SortArray(new int[] { }));
        }

        public static int[] SortArray(int[] array)
        {
            return array;
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        //https://www.codewars.com/kata/a-rule-of-divisibility-by-13/train/csharp
        //13 의 법칙. 어떤 숫자를 13으로 나눳을 때 나머지가 얼마인지 알고싶을 때,
        // 해당 숫자를 뒤집은 후, 각 자릿수에 다음 순열을 차례대로 곱한다 (1, 10, 9, 12, 3, 4)
        // 그리고 그 결과에 대해 한번 더 돌려서 그 결과가 같을 때, 그 결과를 13으로 나누면 나머지가 나오는데 그 나머지는 원래 숫자를 13으로 나눈 것과 같다.
        // 이 문제는 그 '같은 결과 숫자' 를 반환하는 것이다. (나머지를 반환하는 것이 아님)
        // Example: What is the remainder when 1234567 is divided by 13?
        // 7×1 + 6×10 + 5×9 + 4×12 + 3×3 + 2×4 + 1×1 = 178
        // We repeat the process with 178:
        // 8x1 + 7x10 + 1x9 = 87
        // and again with 87:
        // 7x1 + 8x10 = 87
        // 이므로 87을 반환하라는 것.

        [TestFixture]
        public static class ThirteenTests
        {
            private static void testing(long actual, long expected)
            {
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public static void test1()
            {
                Console.WriteLine("Testing Thirt");
                testing(Thirteen.Thirt(8529), 79);
                testing(Thirteen.Thirt(85299258), 31);
                testing(Thirteen.Thirt(5634), 57);
                testing(Thirteen.Thirt(1111111111), 71);
                testing(Thirteen.Thirt(987654321), 30);
            }
        }

        public class Thirteen
        {
            public static long Thirt(long n)
            {
                return 0;
            }
        }
    }
}