using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.domain.Base
{
    // abstract é uma classe que não pode ser instanciada, servindo apenas de modelo ou herança, o <TID> serve para definir o tipo de ID sem alterar o código.
    public abstract class BaseEntity<TID>
    {
        protected BaseEntity() {
        
        }
        protected BaseEntity(TID id) {
            Id = id;
        }
        public TID? Id { get; set; }

    }
}
