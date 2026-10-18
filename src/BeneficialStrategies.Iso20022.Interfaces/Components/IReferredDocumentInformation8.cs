// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Referred Document Information8.
/// </summary>
[IsoId("_OzVnATE0Ee62xuUQ2zyZww")]
public interface IReferredDocumentInformation8 : IIsoComponent
{
    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IDocumentType1? Type { get; }

    /// <summary>
    /// Number.
    /// </summary>
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    Max35Text? Number { get; }

    /// <summary>
    /// Related Date.
    /// </summary>
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    IDateAndType1? RelatedDate { get; }

    /// <summary>
    /// Line Details.
    /// </summary>
    [DisplayName("Line Details")]
    [IsoXmlTag("LineDtls")]
    IEnumerable<IDocumentLineInformation2> LineDetails { get; }
}
