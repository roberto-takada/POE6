﻿using IFSPStore.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.domain.Entities
{
    public class Cliente: BaseEntity<int>
    {
        public Cliente() {
        
        }
        public Cliente(int id, string nome, string endereco, string bairro, string documento, Cidade cidade)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Bairro = bairro;
            Documento = documento;
            Cidade = cidade;
        }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public string? Documento { get; set; }
        public Cidade Cidade { get; set; }


    }
}
