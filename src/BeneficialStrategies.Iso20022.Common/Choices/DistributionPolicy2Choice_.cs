// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a distribution policy.
    /// </summary>
    [KnownType(typeof(DistributionPolicy2Choice.Code))]
    [KnownType(typeof(DistributionPolicy2Choice.Proprietary))]
    [JsonDerivedType(typeof(DistributionPolicy2Choice.Code),nameof(DistributionPolicy2Choice.Code))]
    [JsonDerivedType(typeof(DistributionPolicy2Choice.Proprietary),nameof(DistributionPolicy2Choice.Proprietary))]
    [IsoId("_HolxYeLaEeWFtOV72FbX9w")]
    [DisplayName("Distribution Policy 2 Choice")]
    public abstract partial record DistributionPolicy2Choice_
    {
    }
}
