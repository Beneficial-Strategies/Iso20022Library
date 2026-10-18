// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IReferredDocumentType2"/>
[IsoId("_T3sBQtp-Ed-ak6NoX_4Aeg_1965243464")]
[DisplayName("Referred Document Type")]
public partial record ReferredDocumentType2
{
    /// <inheritdoc cref="IReferredDocumentType2.CodeOrProprietary"/>
    [IsoId("_T3sBQ9p-Ed-ak6NoX_4Aeg_205404742")]
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required ReferredDocumentType1Choice_ CodeOrProprietary { get; init; }

    /// <inheritdoc cref="IReferredDocumentType2.Issuer"/>
    [IsoId("_T3sBRNp-Ed-ak6NoX_4Aeg_1965243858")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
