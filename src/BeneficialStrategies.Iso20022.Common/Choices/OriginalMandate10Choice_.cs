// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Original Mandate10Choice.
    /// </summary>
    [KnownType(typeof(OriginalMandate10Choice.OriginalMandate))]
    [KnownType(typeof(OriginalMandate10Choice.OriginalMandateIdentification))]
    [JsonDerivedType(
        typeof(OriginalMandate10Choice.OriginalMandate),
        nameof(OriginalMandate10Choice.OriginalMandate)
    )]
    [JsonDerivedType(
        typeof(OriginalMandate10Choice.OriginalMandateIdentification),
        nameof(OriginalMandate10Choice.OriginalMandateIdentification)
    )]
    [IsoId("_yNcaETEyEe6g-ffJsqGiSA")]
    [DisplayName("Original Mandate10Choice")]
    public abstract record OriginalMandate10Choice_ { }
}
