// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to define the tax record.
/// </summary>
[IsoId("_yKFWd69fEeen6L7OP7lnvg")]
public interface ITaxRecord2 : IIsoComponent
{
    /// <summary>
    /// High level code to identify the type of tax details.
    /// </summary>
    [IsoId("_yeA_A69fEeen6L7OP7lnvg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    Max35Text? Type { get; }

    /// <summary>
    /// Specifies the tax code as published by the tax authority.
    /// </summary>
    [IsoId("_yeA_Ba9fEeen6L7OP7lnvg")]
    [DisplayName("Category")]
    [IsoXmlTag("Ctgy")]
    Max35Text? Category { get; }

    /// <summary>
    /// Provides further details of the category tax code.
    /// </summary>
    [IsoId("_yeA_B69fEeen6L7OP7lnvg")]
    [DisplayName("Category Details")]
    [IsoXmlTag("CtgyDtls")]
    Max35Text? CategoryDetails { get; }

    /// <summary>
    /// Code provided by local authority to identify the status of the party that has drawn up the settlement document.
    /// </summary>
    [IsoId("_yeA_Ca9fEeen6L7OP7lnvg")]
    [DisplayName("Debtor Status")]
    [IsoXmlTag("DbtrSts")]
    Max35Text? DebtorStatus { get; }

    /// <summary>
    /// Identification number of the tax report as assigned by the taxing authority.
    /// </summary>
    [IsoId("_yeA_C69fEeen6L7OP7lnvg")]
    [DisplayName("Certificate Identification")]
    [IsoXmlTag("CertId")]
    Max35Text? CertificateIdentification { get; }

    /// <summary>
    /// Identifies, in a coded form, on which template the tax report is to be provided.
    /// </summary>
    [IsoId("_yeA_Da9fEeen6L7OP7lnvg")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    Max35Text? FormsCode { get; }

    /// <summary>
    /// Set of elements used to provide details on the period of time related to the tax payment.
    /// </summary>
    [IsoId("_yeA_D69fEeen6L7OP7lnvg")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    ITaxPeriod2? Period { get; }

    /// <summary>
    /// Set of elements used to provide information on the amount of the tax record.
    /// </summary>
    [IsoId("_yeA_Ea9fEeen6L7OP7lnvg")]
    [DisplayName("Tax Amount")]
    [IsoXmlTag("TaxAmt")]
    ITaxAmount2? TaxAmount { get; }

    /// <summary>
    /// Further details of the tax record.
    /// </summary>
    [IsoId("_yeA_E69fEeen6L7OP7lnvg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    Max140Text? AdditionalInformation { get; }
}
