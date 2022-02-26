using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public int QuarInd { get; set; }

        public Cliente(string nome, string email, int quarInd)
        {
            Nome = nome;
            Email = email;
            QuarInd = quarInd;
        }

        public override string ToString()
        {
            return QuarInd + ": " + Nome + ", " + Email;
        }
    }
}
