// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IReferredDocumentType4"/>
[IsoId("_Xf7GCR77EeSxevWRRWxNAg")]
[DisplayName("Referred Document Type")]
public partial record ReferredDocumentType4
{
    /// <inheritdoc cref="IReferredDocumentType4.CodeOrProprietary"/>
    [IsoId("_XxL1Ix77EeSxevWRRWxNAg")]
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required ReferredDocumentType3Choice_ CodeOrProprietary { get; init; }

    /// <inheritdoc cref="IReferredDocumentType4.Issuer"/>
    [IsoId("_XxL1JR77EeSxevWRRWxNAg")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
