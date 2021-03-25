using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class UserOperationClaim: IEntity
    {

        public int id { get; set; }
        public int userId { get; set; }
        public int operationClaimId { get; set; }

    }
}
