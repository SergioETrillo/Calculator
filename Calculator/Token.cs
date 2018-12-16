using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Token
    {
        private readonly TokenType type;
        private readonly double value;

        public Token(TokenType type, double value = Double.NaN)
        {
            this.type = type;
            this.value = value;
        }
    }

    public enum TokenType
    {
        Number,
        OpenParenthesis,
        CloseParenthesis,
        Add,
        Subtract,
        Multiply,
        Divide,
    }
}
