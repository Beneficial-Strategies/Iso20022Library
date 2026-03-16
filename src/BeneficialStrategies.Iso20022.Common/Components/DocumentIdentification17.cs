// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a document by a unique identification.
/// </summary>
[IsoId("_XWm_Otp-Ed-ak6NoX_4Aeg_-1145599038")]
[DisplayName("Document Identification")]
public record DocumentIdentification17
{
    /// <summary>
    /// Identifies the document.
    /// </summary>
    [IsoId("_XWwwMNp-Ed-ak6NoX_4Aeg_2038456839")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text Identification { get; init; }
}
