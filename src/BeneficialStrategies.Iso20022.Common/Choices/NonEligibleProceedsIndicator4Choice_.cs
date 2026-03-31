// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the eligibility of outturn resources.
    /// </summary>
    [KnownType(typeof(NonEligibleProceedsIndicator4Choice.Code))]
    [KnownType(typeof(NonEligibleProceedsIndicator4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(NonEligibleProceedsIndicator4Choice.Code),
        nameof(NonEligibleProceedsIndicator4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(NonEligibleProceedsIndicator4Choice.Proprietary),
        nameof(NonEligibleProceedsIndicator4Choice.Proprietary)
    )]
    [IsoId("_cthE85KQEeWHWpTQn1FFVg")]
    [DisplayName("Non Eligible Proceeds Indicator 4 Choice")]
    public abstract record NonEligibleProceedsIndicator4Choice_ { }
}
