using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.tabuleiro.exceptions
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg)
        {

        }
    }
}
