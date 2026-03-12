// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of distribution.
    /// </summary>
    [KnownType(typeof(DistributionTypeFormat3Choice.Code))]
    [KnownType(typeof(DistributionTypeFormat3Choice.Proprietary))]
    [JsonDerivedType(typeof(DistributionTypeFormat3Choice.Code),nameof(DistributionTypeFormat3Choice.Code))]
    [JsonDerivedType(typeof(DistributionTypeFormat3Choice.Proprietary),nameof(DistributionTypeFormat3Choice.Proprietary))]
    [IsoId("_A_MZgfmdEeCZMIez125r5g")]
    [DisplayName("Distribution Type Format 3 Choice")]
    public abstract partial record DistributionTypeFormat3Choice_
    {
    }
}
