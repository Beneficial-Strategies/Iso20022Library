// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of intermediate securities distribution.
    /// </summary>
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat9Choice.Code))]
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat9Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IntermediateSecuritiesDistributionTypeFormat9Choice.Code),
        nameof(IntermediateSecuritiesDistributionTypeFormat9Choice.Code)
    )]
    [JsonDerivedType(
        typeof(IntermediateSecuritiesDistributionTypeFormat9Choice.Proprietary),
        nameof(IntermediateSecuritiesDistributionTypeFormat9Choice.Proprietary)
    )]
    [IsoId("_9m7PcfmXEeCobuMakDuHLg")]
    [DisplayName("Intermediate Securities Distribution Type Format 9 Choice")]
    public abstract record IntermediateSecuritiesDistributionTypeFormat9Choice_ { }
}
