using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test
{
    [TestFixture]
    public class EvaluatorTest
    {
        readonly Evaluator calc = new Evaluator();
        [Test]
        public void EmptyReturnsZero()
        {
            Assert.AreEqual(0.0, calc.Evaluate(""));
        }

        [Test]
        public void TwoMinusOneEqualsOne()
        {
            string entry = "2-1";
            Assert.AreEqual(1, calc.Evaluate(entry));
        }

        [Test]
        public void SpacesAreIgnored()
        {
            string entry = " 5    -      1";
            Assert.AreEqual(4, calc.Evaluate(entry));
        }
    }
}
