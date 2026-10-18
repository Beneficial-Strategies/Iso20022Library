// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the documents referred to in the remittance information.
/// </summary>
[IsoId("_XN5h7x77EeSxevWRRWxNAg")]
public interface IReferredDocumentInformation6 : IIsoComponent
{
    /// <summary>
    /// Specifies the type of referred document.
    /// </summary>
    [IsoId("_Xf7GAx77EeSxevWRRWxNAg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IReferredDocumentType4? Type { get; }

    /// <summary>
    /// Unique and unambiguous identification of the referred document.
    /// </summary>
    [IsoId("_Xf7GBR77EeSxevWRRWxNAg")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    Max35Text? Number { get; }

    /// <summary>
    /// Date associated with the referred document.
    /// </summary>
    [IsoId("_Xf7GBx77EeSxevWRRWxNAg")]
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    ISODate? RelatedDate { get; }
}
