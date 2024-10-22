﻿using IFSPStore.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.domain.Entities
{
    public class Usuario: BaseEntity<int>
    {
        public Usuario() { }
        public Usuario(int id, string nome, string senha, string login, string email, DateTime dataCadastro, DateTime dataLogin, bool ativo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Senha = senha;
            this.Login = login;
            this.Email = email;
            this.DataCadastro = dataCadastro;
            this.DataLogin = dataLogin;
            this.Ativo = ativo;
        }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataLogin { get; set; }
        public bool Ativo {  get; set; }


    }
}
