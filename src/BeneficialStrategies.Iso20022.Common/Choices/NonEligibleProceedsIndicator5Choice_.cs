// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Non Eligible Proceeds Indicator5Choice.
    /// </summary>
    [KnownType(typeof(NonEligibleProceedsIndicator5Choice.Code))]
    [KnownType(typeof(NonEligibleProceedsIndicator5Choice.Proprietary))]
    [JsonDerivedType(typeof(NonEligibleProceedsIndicator5Choice.Code),nameof(NonEligibleProceedsIndicator5Choice.Code))]
    [JsonDerivedType(typeof(NonEligibleProceedsIndicator5Choice.Proprietary),nameof(NonEligibleProceedsIndicator5Choice.Proprietary))]
    [IsoId("_U6Vl0WHZEe6yt_d72zQZeQ")]
    [DisplayName("Non Eligible Proceeds Indicator5Choice")]
    public abstract partial record NonEligibleProceedsIndicator5Choice_
    {
    }
}
