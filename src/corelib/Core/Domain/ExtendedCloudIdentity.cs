using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net.openstack.Core.Domain
{
    public class ExtendedCloudIdentity : CloudIdentity
    {
        public string TenantName { get; set; }
    }
}
