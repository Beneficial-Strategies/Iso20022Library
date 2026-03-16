// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of intermediate securities distribution.
    /// </summary>
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat18Choice.Code))]
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat18Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IntermediateSecuritiesDistributionTypeFormat18Choice.Code),
        nameof(IntermediateSecuritiesDistributionTypeFormat18Choice.Code)
    )]
    [JsonDerivedType(
        typeof(IntermediateSecuritiesDistributionTypeFormat18Choice.Proprietary),
        nameof(IntermediateSecuritiesDistributionTypeFormat18Choice.Proprietary)
    )]
    [IsoId("_cta-E5KQEeWHWpTQn1FFVg")]
    [DisplayName("Intermediate Securities Distribution Type Format 18 Choice")]
    public abstract record IntermediateSecuritiesDistributionTypeFormat18Choice_ { }
}
