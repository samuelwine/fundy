using Fundy.Core.Records;
using Fundy.SharedKernel;
using Fundy.SharedKernel.Interfaces;
using System.Collections.Generic;

namespace Fundy.Core.Entities
{
    public class Donor : BaseEntity, IAggregateRoot
    {
        public Name Name { get; set; } = null!;

        public Address HomeAddress { get; set; } = null!;

        public Address WorkAddress { get; set; } = null!;
        

    }
}
