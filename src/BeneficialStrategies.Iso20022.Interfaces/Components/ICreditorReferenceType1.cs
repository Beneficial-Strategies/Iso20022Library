// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of the documents referred by the creditor.
/// </summary>
[IsoId("_T31ySNp-Ed-ak6NoX_4Aeg_96960704")]
public interface ICreditorReferenceType1 : IIsoComponent
{
    /// <summary>
    /// Coded creditor reference type.
    /// </summary>
    [IsoId("_T31ySdp-Ed-ak6NoX_4Aeg_96961291")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    DocumentType3Code Code { get; }

    /// <summary>
    /// Creditor reference type not avilable in a coded format.
    /// </summary>
    [IsoId("_T31yStp-Ed-ak6NoX_4Aeg_96961652")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    IsoMax35Text Proprietary { get; }

    /// <summary>
    /// Identification of the issuer of the credit reference type.
    /// </summary>
    [IsoId("_T3_jQNp-Ed-ak6NoX_4Aeg_96961712")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    IsoMax35Text? Issuer { get; }
}
