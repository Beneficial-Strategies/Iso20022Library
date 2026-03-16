// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the CCP eligibility information.
    /// </summary>
    [KnownType(typeof(CentralCounterPartyEligibility5Choice.Indicator))]
    [KnownType(typeof(CentralCounterPartyEligibility5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CentralCounterPartyEligibility5Choice.Indicator),
        nameof(CentralCounterPartyEligibility5Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(CentralCounterPartyEligibility5Choice.Proprietary),
        nameof(CentralCounterPartyEligibility5Choice.Proprietary)
    )]
    [IsoId("_5m6oM5NLEeWGlc8L7oPDIg")]
    [DisplayName("Central Counter Party Eligibility 5 Choice")]
    public abstract record CentralCounterPartyEligibility5Choice_ { }
}
