// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to define the tax record.
/// </summary>
[IsoId("_UP-lfdp-Ed-ak6NoX_4Aeg_-1626596263")]
[DisplayName("Tax Record")]
public record TaxRecord1
{
    /// <summary>
    /// High level code to identify the type of tax details.
    /// </summary>
    [IsoId("_UP-lftp-Ed-ak6NoX_4Aeg_-1148727004")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Specifies the tax code as published by the tax authority.
    /// </summary>
    [IsoId("_UQIWcNp-Ed-ak6NoX_4Aeg_1498485302")]
    [DisplayName("Category")]
    [IsoXmlTag("Ctgy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Category { get; init; }

    /// <summary>
    /// Provides further details of the category tax code.
    /// </summary>
    [IsoId("_UQIWcdp-Ed-ak6NoX_4Aeg_1500331706")]
    [DisplayName("Category Details")]
    [IsoXmlTag("CtgyDtls")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CategoryDetails { get; init; }

    /// <summary>
    /// Code provided by local authority to identify the status of the party that has drawn up the settlement document.
    /// </summary>
    [IsoId("_UQIWctp-Ed-ak6NoX_4Aeg_-1691952532")]
    [DisplayName("Debtor Status")]
    [IsoXmlTag("DbtrSts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DebtorStatus { get; init; }

    /// <summary>
    /// Identification number of the tax report as assigned by the taxing authority.
    /// </summary>
    [IsoId("_UQIWc9p-Ed-ak6NoX_4Aeg_-1626596261")]
    [DisplayName("Certificate Identification")]
    [IsoXmlTag("CertId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CertificateIdentification { get; init; }

    /// <summary>
    /// Identifies, in a coded form, on which template the tax report is to be provided.
    /// </summary>
    [IsoId("_UQIWdNp-Ed-ak6NoX_4Aeg_-1462919201")]
    [DisplayName("Forms Code")]
    [IsoXmlTag("FrmsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FormsCode { get; init; }

    /// <summary>
    /// Set of elements used to provide details on the period of time related to the tax payment.
    /// </summary>
    [IsoId("_UQIWddp-Ed-ak6NoX_4Aeg_-1864651230")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public TaxPeriod1? Period { get; init; }

    /// <summary>
    /// Set of elements used to provide information on the amount of the tax record.
    /// </summary>
    [IsoId("_UQIWdtp-Ed-ak6NoX_4Aeg_-1626595952")]
    [DisplayName("Tax Amount")]
    [IsoXmlTag("TaxAmt")]
    public TaxAmount1? TaxAmount { get; init; }

    /// <summary>
    /// Further details of the tax record.
    /// </summary>
    [IsoId("_UQIWd9p-Ed-ak6NoX_4Aeg_-576338980")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; }
}
