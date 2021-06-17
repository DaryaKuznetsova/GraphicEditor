using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Common
{
    public abstract class PersistableItemBase
    {
        public PersistableItemBase()
        {

        }

        public PersistableItemBase(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }
    }
}
