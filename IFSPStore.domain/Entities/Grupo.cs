﻿using IFSPStore.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.domain.Entities
{
    public class Grupo: BaseEntity<int>
    {
        public Grupo() { }
        public Grupo(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
        public string? Nome { get; set; }
    }
}
