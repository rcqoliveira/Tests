using NUnit.Framework;

namespace RC.Converter.Roman.Numerals.Test
{
    public class ConverterOfNumberRomanTest
    {
        private readonly ConverterOfNumberRoman _numberRoman = new ConverterOfNumberRoman();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void MustUnderstandTheSymbolI()
        {
            Assert.AreEqual(1, _numberRoman.ToConvert("I"));
        }

        [Test]
        public void MustUnderstandTheSymbolV()
        {
            Assert.AreEqual(5, _numberRoman.ToConvert("V"));
        }

        [Test]
        public void MustUnderstandTheSymbolX()
        {
            Assert.AreEqual(10, _numberRoman.ToConvert("X"));
        }

        [Test]
        public void MustUnderstandTheSymbolL()
        {
            Assert.AreEqual(50, _numberRoman.ToConvert("L"));
        }

        [Test]
        public void MustUnderstandTheSymbolC()
        {
            Assert.AreEqual(100, _numberRoman.ToConvert("C"));
        }

        [Test]
        public void MustUnderstandTheSymbolD()
        {
            Assert.AreEqual(500, _numberRoman.ToConvert("D"));
        }

        [Test]
        public void MustUnderstandTheSymbolM()
        {
            Assert.AreEqual(1000, _numberRoman.ToConvert("M"));
        }

        [Test]
        public void MustUnderstandTheSymbolII()
        {
            Assert.AreEqual(2, _numberRoman.ToConvert("II"));
        }

        [Test]
        public void MustUnderstandTheSymbolVI()
        {
            Assert.AreEqual(6, _numberRoman.ToConvert("VI"));
        }

        [Test]
        public void MustUnderstandTheSymbolIV()
        {
            Assert.AreEqual(4, _numberRoman.ToConvert("IV"));
        }

        [Test]
        [TestCase("I", ExpectedResult = 1)]
        [TestCase("V", ExpectedResult = 5)]
        [TestCase("X", ExpectedResult = 10)]
        [TestCase("XX", ExpectedResult = 20)]
        [TestCase("L", ExpectedResult = 50)]
        [TestCase("C", ExpectedResult = 100)]
        [TestCase("D", ExpectedResult = 500)]
        [TestCase("M", ExpectedResult = 1000)]
        [TestCase("MX", ExpectedResult = 1010)]
        public int MustUnderstandTheSymbol(string value)
        {
            return _numberRoman.ToConvert(value);
        }
    }
}