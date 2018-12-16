using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Tokenizer
    {
        public List<Token> Tokens { get; } 
        private readonly StringReader reader;
        public double Number { get; private set; }
        public Tokenizer(StringReader reader)
        {
            this.reader = reader;
            Tokens = new List<Token>();
        }

        public void Parse()
        {
            char currentChar = NextChar();
            while (currentChar != '\0')
            {
                switch (currentChar)
                {
                    case ' ':
                        break;
                    case '+':
                        Tokens.Add(new Token(TokenType.Add));
                        break;
                    case '-':
                        Tokens.Add(new Token(TokenType.Subtract));
                        break;
                    case '*':
                        Tokens.Add(new Token(TokenType.Multiply));
                        break;
                    case '/':
                        Tokens.Add(new Token(TokenType.Divide));
                        break;
                    case '(':
                        Tokens.Add(new Token(TokenType.OpenParenthesis));
                        break;
                    case ')':
                        Tokens.Add(new Token(TokenType.OpenParenthesis));
                        break;
                    default:
                        GetNumber(currentChar);
                        Tokens.Add(new Token(TokenType.Number, Number));
                        break;
                }

                currentChar = NextChar();
            }
        }

        public void GetNumber(char currentChar)
        {
            string numberStr = currentChar.ToString();
            char current = NextChar();
            while (Char.IsDigit(current) || current == '.')
            {
                numberStr += current;
                current = NextChar();
            }

            Number = Double.Parse(numberStr);
        }

        public char NextChar()
        {
            int next = reader.Read();
            return next < 0 ? '\0' : (char) next;
        }
    }

}
