// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IReferredDocumentType1"/>
[IsoId("_T31yQdp-Ed-ak6NoX_4Aeg_788285148")]
[DisplayName("Referred Document Type")]
public partial record ReferredDocumentType1
{
    /// <inheritdoc cref="IReferredDocumentType1.Code"/>
    [IsoId("_T31yQtp-Ed-ak6NoX_4Aeg_1742281673")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required DocumentType2Code Code { get; init; }

    /// <inheritdoc cref="IReferredDocumentType1.Proprietary"/>
    [IsoId("_T31yQ9p-Ed-ak6NoX_4Aeg_1745976831")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Proprietary { get; init; }

    /// <inheritdoc cref="IReferredDocumentType1.Issuer"/>
    [IsoId("_T31yRNp-Ed-ak6NoX_4Aeg_1757060568")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
