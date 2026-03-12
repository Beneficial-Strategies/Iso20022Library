// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the CCP eligibility information.
    /// </summary>
    [KnownType(typeof(CentralCounterPartyEligibility4Choice.Indicator))]
    [KnownType(typeof(CentralCounterPartyEligibility4Choice.Proprietary))]
    [JsonDerivedType(typeof(CentralCounterPartyEligibility4Choice.Indicator),nameof(CentralCounterPartyEligibility4Choice.Indicator))]
    [JsonDerivedType(typeof(CentralCounterPartyEligibility4Choice.Proprietary),nameof(CentralCounterPartyEligibility4Choice.Proprietary))]
    [IsoId("__-aJkTqIEeWVrPy0StzzSg")]
    [DisplayName("Central Counter Party Eligibility 4 Choice")]
    public abstract partial record CentralCounterPartyEligibility4Choice_
    {
    }
}
