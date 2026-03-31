// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of distribution.
    /// </summary>
    [KnownType(typeof(DistributionTypeFormat4Choice.Code))]
    [KnownType(typeof(DistributionTypeFormat4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(DistributionTypeFormat4Choice.Code),
        nameof(DistributionTypeFormat4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(DistributionTypeFormat4Choice.Proprietary),
        nameof(DistributionTypeFormat4Choice.Proprietary)
    )]
    [IsoId("_3WE64SXXEeOFIcNWlDEvdQ")]
    [DisplayName("Distribution Type Format 4 Choice")]
    public abstract record DistributionTypeFormat4Choice_ { }
}
