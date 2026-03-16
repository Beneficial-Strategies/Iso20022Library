// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the distribution type.
    /// </summary>
    [KnownType(typeof(DistributionType1FormatChoice.Code))]
    [KnownType(typeof(DistributionType1FormatChoice.Proprietary))]
    [JsonDerivedType(
        typeof(DistributionType1FormatChoice.Code),
        nameof(DistributionType1FormatChoice.Code)
    )]
    [JsonDerivedType(
        typeof(DistributionType1FormatChoice.Proprietary),
        nameof(DistributionType1FormatChoice.Proprietary)
    )]
    [IsoId("_RmZ7Jdp-Ed-ak6NoX_4Aeg_-1392239918")]
    [DisplayName("Distribution Type 1 Format Choice")]
    public abstract record DistributionType1FormatChoice_ { }
}
