// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of the document referred in the remittance information.
/// </summary>
[IsoId("_T3sBQtp-Ed-ak6NoX_4Aeg_1965243464")]
public interface IReferredDocumentType2 : IIsoComponent
{
    /// <summary>
    /// Provides the type details of the referred document.
    /// </summary>
    [IsoId("_T3sBQ9p-Ed-ak6NoX_4Aeg_205404742")]
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    IReferredDocumentType1Choice CodeOrProprietary { get; }

    /// <summary>
    /// Identification of the issuer of the reference document type.
    /// </summary>
    [IsoId("_T3sBRNp-Ed-ak6NoX_4Aeg_1965243858")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    IsoMax35Text? Issuer { get; }
}
