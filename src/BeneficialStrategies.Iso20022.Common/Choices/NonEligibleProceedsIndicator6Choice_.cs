// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Non Eligible Proceeds Indicator6Choice.
    /// </summary>
    [KnownType(typeof(NonEligibleProceedsIndicator6Choice.Code))]
    [KnownType(typeof(NonEligibleProceedsIndicator6Choice.Proprietary))]
    [JsonDerivedType(typeof(NonEligibleProceedsIndicator6Choice.Code),nameof(NonEligibleProceedsIndicator6Choice.Code))]
    [JsonDerivedType(typeof(NonEligibleProceedsIndicator6Choice.Proprietary),nameof(NonEligibleProceedsIndicator6Choice.Proprietary))]
    [IsoId("_U1VOQ3SdEe6VWZz2tTgENw")]
    [DisplayName("Non Eligible Proceeds Indicator6Choice")]
    public abstract partial record NonEligibleProceedsIndicator6Choice_
    {
    }
}
