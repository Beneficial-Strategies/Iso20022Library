// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of intermediate securities distribution.
    /// </summary>
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat6Choice.Code))]
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat6Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IntermediateSecuritiesDistributionTypeFormat6Choice.Code),
        nameof(IntermediateSecuritiesDistributionTypeFormat6Choice.Code)
    )]
    [JsonDerivedType(
        typeof(IntermediateSecuritiesDistributionTypeFormat6Choice.Proprietary),
        nameof(IntermediateSecuritiesDistributionTypeFormat6Choice.Proprietary)
    )]
    [IsoId("_x8LwkeAZEd-D2OAFXdoRmA")]
    [DisplayName("Intermediate Securities Distribution Type Format 6 Choice")]
    public abstract record IntermediateSecuritiesDistributionTypeFormat6Choice_ { }
}
