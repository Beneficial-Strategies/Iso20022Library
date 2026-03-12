// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of distribution.
    /// </summary>
    [KnownType(typeof(DistributionTypeFormat8Choice.Code))]
    [KnownType(typeof(DistributionTypeFormat8Choice.Proprietary))]
    [JsonDerivedType(typeof(DistributionTypeFormat8Choice.Code),nameof(DistributionTypeFormat8Choice.Code))]
    [JsonDerivedType(typeof(DistributionTypeFormat8Choice.Proprietary),nameof(DistributionTypeFormat8Choice.Proprietary))]
    [IsoId("_c5VTk5KQEeWHWpTQn1FFVg")]
    [DisplayName("Distribution Type Format 8 Choice")]
    public abstract partial record DistributionTypeFormat8Choice_
    {
    }
}
