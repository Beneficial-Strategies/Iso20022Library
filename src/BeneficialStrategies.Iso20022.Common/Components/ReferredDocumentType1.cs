// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of the document referred in the remittance information.
/// </summary>
[IsoId("_T31yQdp-Ed-ak6NoX_4Aeg_788285148")]
[DisplayName("Referred Document Type")]
public record ReferredDocumentType1
{
    /// <summary>
    /// Document type in a coded form.
    /// </summary>
    [IsoId("_T31yQtp-Ed-ak6NoX_4Aeg_1742281673")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required DocumentType2Code Code { get; init; }

    /// <summary>
    /// Proprietary identification of the type of the remittance document.
    /// </summary>
    [IsoId("_T31yQ9p-Ed-ak6NoX_4Aeg_1745976831")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Proprietary { get; init; }

    /// <summary>
    /// Identification of the issuer of the reference document type.
    /// </summary>
    [IsoId("_T31yRNp-Ed-ak6NoX_4Aeg_1757060568")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
