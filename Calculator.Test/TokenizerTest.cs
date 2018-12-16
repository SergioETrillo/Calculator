﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test
{
    [TestFixture]
    class TokenizerTest
    {
        [Test]
        public void GetNumberTest()
        {
            string expression = "3.75";
            var tokenizer = new Tokenizer(new StringReader(expression));
            tokenizer.GetNumber('3');
            Assert.AreEqual(33.75, tokenizer.Number);
        }
    }
}
