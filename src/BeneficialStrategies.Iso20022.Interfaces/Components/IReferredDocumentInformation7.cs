// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the documents referred to in the remittance information.
/// </summary>
[IsoId("_0X1uUzq4EeWZFYSPlduMhw")]
public interface IReferredDocumentInformation7 : IIsoComponent
{
    /// <summary>
    /// Specifies the type of referred document.
    /// </summary>
    [IsoId("_0feAQzq4EeWZFYSPlduMhw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IReferredDocumentType4? Type { get; }

    /// <summary>
    /// Unique and unambiguous identification of the referred document.
    /// </summary>
    [IsoId("_0feARTq4EeWZFYSPlduMhw")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    IsoMax35Text? Number { get; }

    /// <summary>
    /// Date associated with the referred document.
    /// </summary>
    [IsoId("_0feARzq4EeWZFYSPlduMhw")]
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    IsoISODate? RelatedDate { get; }

    /// <summary>
    /// Set of elements used to provide the content of the referred document line.
    /// </summary>
    [IsoId("_A4iOsTq5EeWZFYSPlduMhw")]
    [DisplayName("Line Details")]
    [IsoXmlTag("LineDtls")]
    IEnumerable<IDocumentLineInformation1> LineDetails { get; }
}
