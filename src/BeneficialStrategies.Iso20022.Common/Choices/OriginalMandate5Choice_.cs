// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the mandate that is being accepted.
    /// </summary>
    [KnownType(typeof(OriginalMandate5Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate5Choice.OriginalMandate))]
    [JsonDerivedType(
        typeof(OriginalMandate5Choice.OriginalMandateIdentification),
        nameof(OriginalMandate5Choice.OriginalMandateIdentification)
    )]
    [JsonDerivedType(
        typeof(OriginalMandate5Choice.OriginalMandate),
        nameof(OriginalMandate5Choice.OriginalMandate)
    )]
    [IsoId("_yur0cZR8EeazAtAtDSg0Nw")]
    [DisplayName("Original Mandate 5 Choice")]
    public abstract record OriginalMandate5Choice_ { }
}
