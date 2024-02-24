using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstracts;

namespace Entities.Concretes
{
    public class EntityBase : IEntity
    {
        public int Id { get; set; }
    }
}
