// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the mandate that is being accepted.
    /// </summary>
    [KnownType(typeof(OriginalMandate4Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate4Choice.OriginalMandate))]
    [JsonDerivedType(
        typeof(OriginalMandate4Choice.OriginalMandateIdentification),
        nameof(OriginalMandate4Choice.OriginalMandateIdentification)
    )]
    [JsonDerivedType(
        typeof(OriginalMandate4Choice.OriginalMandate),
        nameof(OriginalMandate4Choice.OriginalMandate)
    )]
    [IsoId("_cvK7RUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Mandate 4 Choice")]
    public abstract record OriginalMandate4Choice_ { }
}
