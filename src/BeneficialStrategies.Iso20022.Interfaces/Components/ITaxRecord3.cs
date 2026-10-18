// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to define the tax record.
/// </summary>
[IsoId("_n9ZPV94lEeqt1ZcLzWyWFw")]
public interface ITaxRecord3 : IIsoComponent
{
    /// <summary>
    /// High level code to identify the type of tax details.
    /// </summary>
    [IsoId("_n-65Qd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    IsoMax35Text? Type { get; }

    /// <summary>
    /// Specifies the tax code as published by the tax authority.
    /// </summary>
    [IsoId("_n-65Q94lEeqt1ZcLzWyWFw")]
    [DisplayName("Category")]
    [IsoXmlTag("Ctgy")]
    IsoMax35Text? Category { get; }

    /// <summary>
    /// Provides further details of the category tax code.
    /// </summary>
    [IsoId("_n-65Rd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Category Details")]
    [IsoXmlTag("CtgyDtls")]
    IsoMax35Text? CategoryDetails { get; }

    /// <summary>
    /// Code provided by local authority to identify the status of the party that has drawn up the settlement document.
    /// </summary>
    [IsoId("_n-65R94lEeqt1ZcLzWyWFw")]
    [DisplayName("Debtor Status")]
    [IsoXmlTag("DbtrSts")]
    IsoMax35Text? DebtorStatus { get; }

    /// <summary>
    /// Identification number of the tax report as assigned by the taxing authority.
    /// </summary>
    [IsoId("_n-65Sd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Certificate Identification")]
    [IsoXmlTag("CertId")]
    IsoMax35Text? CertificateIdentification { get; }

    /// <summary>
    /// Identifies, in a coded form, on which template the tax report is to be provided.
    /// </summary>
    [IsoId("_n-65S94lEeqt1ZcLzWyWFw")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    IsoMax35Text? FormsCode { get; }

    /// <summary>
    /// Set of elements used to provide details on the period of time related to the tax payment.
    /// </summary>
    [IsoId("_n-65Td4lEeqt1ZcLzWyWFw")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    ITaxPeriod3? Period { get; }

    /// <summary>
    /// Set of elements used to provide information on the amount of the tax record.
    /// </summary>
    [IsoId("_n-65T94lEeqt1ZcLzWyWFw")]
    [DisplayName("Tax Amount")]
    [IsoXmlTag("TaxAmt")]
    ITaxAmount3? TaxAmount { get; }

    /// <summary>
    /// Further details of the tax record.
    /// </summary>
    [IsoId("_n-65Ud4lEeqt1ZcLzWyWFw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IsoMax140Text? AdditionalInformation { get; }
}
