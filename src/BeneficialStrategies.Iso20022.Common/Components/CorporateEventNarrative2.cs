// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional narrative information about the corporate event.
/// </summary>
[IsoId("_Qotj2dp-Ed-ak6NoX_4Aeg_879212794")]
[DisplayName("Corporate Event Narrative")]
public record CorporateEventNarrative2
{
    /// <summary>
    /// Issuer’s disclaimer notice relative to the meeting announcement information provided. It may be ignored for automated processing.
    /// </summary>
    [IsoId("_Qo3U0Np-Ed-ak6NoX_4Aeg_2043448080")]
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Disclaimer { get; init; }
}
