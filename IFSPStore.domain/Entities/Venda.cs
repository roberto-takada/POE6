using IFSPStore.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IFSPStore.domain.Entities
{
    public class Venda: BaseEntity<int>
    {
        public Venda() {
            Items = new List<VendaItem>();
        }
        public Venda(int id, DateTime data, double valorTotal, int quantidade, Usuario? usuario, Cliente? cliente, List<VendaItem> items) : base(id)
        {
            Id = id;
            Data = data;
            ValorTotal = valorTotal;
            Cliente = cliente;
            Usuario = usuario;
            Items = items;

        }
        public DateTime? Data {  get; set; }
        public double ValorTotal { get; set; }
        public Usuario? Usuario { get; set; }
        public Cliente? Cliente { get; set; }
        public virtual List<VendaItem> Items { get; set; }

        

    }
    
    public class VendaItem: BaseEntity<int> { 
        public VendaItem()
        {

        }

        public VendaItem(int id, Venda venda, int quantidade, double valorTotal, double valorUnitario, Produto produto)
        {
            Id= id;
            Venda = venda;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            ValorTotal = valorTotal;
            Produto = produto;

        }
        public virtual Produto? Produto { get; set; }
        public int Quantidade { get; set; }
        public double? ValorTotal { get; set; }
        public double? ValorUnitario { get; set; }
        [JsonIgnore]
        public virtual Venda? Venda { get; set; }

    }
}
