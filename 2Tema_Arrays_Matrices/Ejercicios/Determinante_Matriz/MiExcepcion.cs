using System;
using System.Collections.Generic;
using System.Text;

namespace Determinante_Matriz
{
    [Serializable]
    class MiExcepcion : Exception
    {
        public MiExcepcion()
        {
        }

        public MiExcepcion(string message): base(message)
        {
        }

        public MiExcepcion(string message, Exception inner): base(message, inner)
        {
        }
    }
}
