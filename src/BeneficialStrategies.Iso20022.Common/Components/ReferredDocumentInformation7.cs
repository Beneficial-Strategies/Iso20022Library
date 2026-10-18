// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IReferredDocumentInformation7"/>
[IsoId("_0X1uUzq4EeWZFYSPlduMhw")]
[DisplayName("Referred Document Information")]
public partial record ReferredDocumentInformation7
{
    /// <inheritdoc cref="IReferredDocumentInformation7.Type"/>
    [IsoId("_0feAQzq4EeWZFYSPlduMhw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ReferredDocumentType4? Type { get; init; }

    /// <inheritdoc cref="IReferredDocumentInformation7.Number"/>
    [IsoId("_0feARTq4EeWZFYSPlduMhw")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Number { get; init; }

    /// <inheritdoc cref="IReferredDocumentInformation7.RelatedDate"/>
    [IsoId("_0feARzq4EeWZFYSPlduMhw")]
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RelatedDate { get; init; }

    /// <inheritdoc cref="IReferredDocumentInformation7.LineDetails"/>
    [IsoId("_A4iOsTq5EeWZFYSPlduMhw")]
    [DisplayName("Line Details")]
    [IsoXmlTag("LineDtls")]
    public ValueList<DocumentLineInformation1> LineDetails { get; init; } = [];
}
