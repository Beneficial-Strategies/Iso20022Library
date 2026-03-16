// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of intermediate securities distribution.
    /// </summary>
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat1Choice.Code))]
    [KnownType(typeof(IntermediateSecuritiesDistributionTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IntermediateSecuritiesDistributionTypeFormat1Choice.Code),
        nameof(IntermediateSecuritiesDistributionTypeFormat1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(IntermediateSecuritiesDistributionTypeFormat1Choice.Proprietary),
        nameof(IntermediateSecuritiesDistributionTypeFormat1Choice.Proprietary)
    )]
    [IsoId("_Q3Unktp-Ed-ak6NoX_4Aeg_1110084007")]
    [DisplayName("Intermediate Securities Distribution Type Format 1 Choice")]
    public abstract record IntermediateSecuritiesDistributionTypeFormat1Choice_ { }
}
