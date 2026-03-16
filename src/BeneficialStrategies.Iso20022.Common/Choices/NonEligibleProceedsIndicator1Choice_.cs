// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the eligibility of outturn resources.
    /// </summary>
    [KnownType(typeof(NonEligibleProceedsIndicator1Choice.Code))]
    [KnownType(typeof(NonEligibleProceedsIndicator1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(NonEligibleProceedsIndicator1Choice.Code),
        nameof(NonEligibleProceedsIndicator1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(NonEligibleProceedsIndicator1Choice.Proprietary),
        nameof(NonEligibleProceedsIndicator1Choice.Proprietary)
    )]
    [IsoId("_Q5GwR9p-Ed-ak6NoX_4Aeg_-1230859873")]
    [DisplayName("Non Eligible Proceeds Indicator 1 Choice")]
    public abstract record NonEligibleProceedsIndicator1Choice_ { }
}
