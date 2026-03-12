// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of distribution.
    /// </summary>
    [KnownType(typeof(DistributionTypeFormat7Choice.Code))]
    [KnownType(typeof(DistributionTypeFormat7Choice.Proprietary))]
    [JsonDerivedType(typeof(DistributionTypeFormat7Choice.Code),nameof(DistributionTypeFormat7Choice.Code))]
    [JsonDerivedType(typeof(DistributionTypeFormat7Choice.Proprietary),nameof(DistributionTypeFormat7Choice.Proprietary))]
    [IsoId("_4kYtQUEFEeWVgfuHGaKtRQ")]
    [DisplayName("Distribution Type Format 7 Choice")]
    public abstract partial record DistributionTypeFormat7Choice_
    {
    }
}
