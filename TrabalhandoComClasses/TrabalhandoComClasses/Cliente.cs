﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.CaixaEletronico.Usuarios
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string rg;
        public string cpf;
        public string endereco;
        public int idade;

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public bool ehDeMaior()
        {
            return this.idade >= 18;
        }
        public override string ToString()
        {
            return Nome;
        }

    }
}
