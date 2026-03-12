// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the eligibility of outturn resources.
    /// </summary>
    [KnownType(typeof(NonEligibleProceedsIndicator3Choice.Code))]
    [KnownType(typeof(NonEligibleProceedsIndicator3Choice.Proprietary))]
    [JsonDerivedType(typeof(NonEligibleProceedsIndicator3Choice.Code),nameof(NonEligibleProceedsIndicator3Choice.Code))]
    [JsonDerivedType(typeof(NonEligibleProceedsIndicator3Choice.Proprietary),nameof(NonEligibleProceedsIndicator3Choice.Proprietary))]
    [IsoId("_MvA2sUEKEeWVgfuHGaKtRQ")]
    [DisplayName("Non Eligible Proceeds Indicator 3 Choice")]
    public abstract partial record NonEligibleProceedsIndicator3Choice_
    {
    }
}
