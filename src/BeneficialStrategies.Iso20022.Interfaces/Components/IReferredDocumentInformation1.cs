// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured information supplied to fully identify the documents referred to in the remittance information.
/// </summary>
[IsoId("_T3sBSNp-Ed-ak6NoX_4Aeg_402190265")]
public interface IReferredDocumentInformation1 : IIsoComponent
{
    /// <summary>
    /// Provides the type of the referred document.
    /// </summary>
    [IsoId("_T3sBSdp-Ed-ak6NoX_4Aeg_1319309617")]
    [DisplayName("Referred Document Type")]
    [IsoXmlTag("RfrdDocTp")]
    IReferredDocumentType1? ReferredDocumentType { get; }

    /// <summary>
    /// Unique and unambiguous identification number of the referred document.
    /// </summary>
    [IsoId("_T31yQNp-Ed-ak6NoX_4Aeg_402190318")]
    [DisplayName("Referred Document Number")]
    [IsoXmlTag("RfrdDocNb")]
    IsoMax35Text? ReferredDocumentNumber { get; }
}
