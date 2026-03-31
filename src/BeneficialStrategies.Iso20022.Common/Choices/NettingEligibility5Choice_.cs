// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the netting eligibility information.
    /// </summary>
    [KnownType(typeof(NettingEligibility5Choice.Indicator))]
    [KnownType(typeof(NettingEligibility5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(NettingEligibility5Choice.Indicator),
        nameof(NettingEligibility5Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(NettingEligibility5Choice.Proprietary),
        nameof(NettingEligibility5Choice.Proprietary)
    )]
    [IsoId("_5m6oEZNLEeWGlc8L7oPDIg")]
    [DisplayName("Netting Eligibility 5 Choice")]
    public abstract record NettingEligibility5Choice_ { }
}
