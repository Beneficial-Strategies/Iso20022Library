// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the competent authority which supervises the reporting counterparty.
/// </summary>
[IsoId("_jODlAIAuEeirUu_C8Wn_0Q")]
[DisplayName("Competent Authority")]
public record CompetentAuthority1
{
    /// <summary>
    /// Identification field for the competent authority.
    /// </summary>
    [IsoId("_r8tXMIAuEeirUu_C8Wn_0Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Identification { get; init; }

    /// <summary>
    /// Information on the onboarding status of the competent authority.
    /// </summary>
    [IsoId("_tq-24IAuEeirUu_C8Wn_0Q")]
    [DisplayName("Onboarding Status")]
    [IsoXmlTag("OnbrdgSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator OnboardingStatus { get; init; }
}
