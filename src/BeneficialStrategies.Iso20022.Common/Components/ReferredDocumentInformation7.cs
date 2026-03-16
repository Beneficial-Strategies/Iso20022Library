// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the documents referred to in the remittance information.
/// </summary>
[IsoId("_0X1uUzq4EeWZFYSPlduMhw")]
[DisplayName("Referred Document Information")]
public record ReferredDocumentInformation7
{
    /// <summary>
    /// Specifies the type of referred document.
    /// </summary>
    [IsoId("_0feAQzq4EeWZFYSPlduMhw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ReferredDocumentType4? Type { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the referred document.
    /// </summary>
    [IsoId("_0feARTq4EeWZFYSPlduMhw")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Number { get; init; }

    /// <summary>
    /// Date associated with the referred document.
    /// </summary>
    [IsoId("_0feARzq4EeWZFYSPlduMhw")]
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RelatedDate { get; init; }

    /// <summary>
    /// Set of elements used to provide the content of the referred document line.
    /// </summary>
    [IsoId("_A4iOsTq5EeWZFYSPlduMhw")]
    [DisplayName("Line Details")]
    [IsoXmlTag("LineDtls")]
    public ValueList<DocumentLineInformation1> LineDetails { get; init; } = [];
}
