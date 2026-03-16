// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Original Mandate11Choice.
    /// </summary>
    [KnownType(typeof(OriginalMandate11Choice.OriginalMandate))]
    [KnownType(typeof(OriginalMandate11Choice.OriginalMandateIdentification))]
    [JsonDerivedType(
        typeof(OriginalMandate11Choice.OriginalMandate),
        nameof(OriginalMandate11Choice.OriginalMandate)
    )]
    [JsonDerivedType(
        typeof(OriginalMandate11Choice.OriginalMandateIdentification),
        nameof(OriginalMandate11Choice.OriginalMandateIdentification)
    )]
    [IsoId("_1iUrOzEyEe6g-ffJsqGiSA")]
    [DisplayName("Original Mandate11Choice")]
    public abstract record OriginalMandate11Choice_ { }
}
