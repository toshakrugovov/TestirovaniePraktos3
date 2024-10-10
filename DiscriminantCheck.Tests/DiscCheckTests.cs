using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DiscriminantCheck;

namespace TDD.Tests
{
    [TestClass]
    public class DiscCheckTests
    {
        static List<double[]> factcoren;
        static List<double[]> ozhidaniekorn;

        [ClassInitialize]
        public static void InitializeCurrentTest(TestContext testContext)
        {
            factcoren = new List<double[]>();
            ozhidaniekorn = new List<double[]>();
        }

        [TestMethod]
        public void DiscMenshenull()
        {
            double a = 1, b = 2, c = 5;

            Discriminant disc = new Discriminant();
            double[] actual = disc.Nahozdeniekorney(a, b, c);
            factcoren.Add(actual);
            double[] expected = new double[0];
            ozhidaniekorn.Add(expected);

            
            CollectionAssert.IsSubsetOf(actual, expected, $"Фактические корни: {factcoren} должны быть подмножеством ожидаемых: {ozhidaniekorn} при D < 0.");
        }

        [TestMethod]
        public void Vicheslenieprocent()
        {
            double chislo = 200;
            double procent = 7.5;

            Discriminant math = new Discriminant();
            double actual = math.Procentotchisla(chislo, procent);
            double expected = 15;
            double delta = 0.001;
            Assert.AreEqual(expected, actual, delta, $"Фактический результат {actual} не соответствует ожидаемому {expected} для числа {chislo} и процента {procent}.");
        }

        [TestMethod]
        public void Discravennull()
        {
            double a = 1, b = 2, c = 1;

            Discriminant math = new Discriminant();
            double[] actual = math.Nahozdeniekorney(a, b, c);
            factcoren.Add(actual);
            double[] expected = new double[] { -1 };
            ozhidaniekorn.Add(expected);

           
            Assert.AreEqual(expected[0], actual[0], $"Ожидался один корень {expected}, фактический корень: {actual[0]}.");
        }

        [TestMethod]
        public void Discbolchenull()
        {
            double a = 1, b = -3, c = 2;

            Discriminant math = new Discriminant();
            double[] actual = math.Nahozdeniekorney(a, b, c);
            factcoren.Add(actual);
            double[] expected = new double[] { 2, 1 };
            ozhidaniekorn.Add(expected);

            
            CollectionAssert.AllItemsAreUnique(actual, $"Корни {actual} ожидалость, что будут уникальными");
            CollectionAssert.AreEquivalent(expected, actual, "D > 0: Ожидались два корня.");
        }
    }
}
