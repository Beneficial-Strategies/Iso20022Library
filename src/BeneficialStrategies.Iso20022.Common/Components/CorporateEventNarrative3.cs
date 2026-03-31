// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides disclaimer narrative information about the event.
/// </summary>
[IsoId("_iy9JkfNAEeqRfth943bvEA")]
[DisplayName("Corporate Event Narrative")]
public record CorporateEventNarrative3
{
    /// <summary>
    /// Issuer’s disclaimer notice relative to the meeting announcement information provided. It may be ignored for automated processing.
    /// </summary>
    [IsoId("_jGvoQfNAEeqRfth943bvEA")]
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public ValueList<LanguageSpecifiedNarrative1> Disclaimer { get; init; } = [];
}
