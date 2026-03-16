// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the CCP eligibility information.
    /// </summary>
    [KnownType(typeof(CentralCounterPartyEligibility1Choice.Indicator))]
    [KnownType(typeof(CentralCounterPartyEligibility1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CentralCounterPartyEligibility1Choice.Indicator),
        nameof(CentralCounterPartyEligibility1Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(CentralCounterPartyEligibility1Choice.Proprietary),
        nameof(CentralCounterPartyEligibility1Choice.Proprietary)
    )]
    [IsoId("_Qvaox9p-Ed-ak6NoX_4Aeg_22450085")]
    [DisplayName("Central Counter Party Eligibility 1 Choice")]
    public abstract record CentralCounterPartyEligibility1Choice_ { }
}
