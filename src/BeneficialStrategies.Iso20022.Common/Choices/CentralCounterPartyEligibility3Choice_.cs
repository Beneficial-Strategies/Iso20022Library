// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the CCP eligibility information.
    /// </summary>
    [KnownType(typeof(CentralCounterPartyEligibility3Choice.Indicator))]
    [KnownType(typeof(CentralCounterPartyEligibility3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CentralCounterPartyEligibility3Choice.Indicator),
        nameof(CentralCounterPartyEligibility3Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(CentralCounterPartyEligibility3Choice.Proprietary),
        nameof(CentralCounterPartyEligibility3Choice.Proprietary)
    )]
    [IsoId("_Aa5owdokEeC60axPepSq7g_-259379707")]
    [DisplayName("Central Counter Party Eligibility 3 Choice")]
    public abstract record CentralCounterPartyEligibility3Choice_ { }
}
