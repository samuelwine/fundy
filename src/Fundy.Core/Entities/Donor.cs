using Fundy.Core.Records;
using Fundy.SharedKernel;
using Fundy.SharedKernel.Interfaces;

namespace Fundy.Core.Entities
{
    public class Donor : BaseEntity, IAggregateRoot
    {
        public Name Name { get; set; }

        //public Address Address { get; set; }
    }
}
