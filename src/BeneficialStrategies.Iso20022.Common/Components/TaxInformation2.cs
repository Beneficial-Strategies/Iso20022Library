// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about tax paid, or to be paid, to the government in accordance with the law, including pre-defined parameters such as thresholds and type of account.
/// </summary>
[IsoId("_RvflsNp-Ed-ak6NoX_4Aeg_-311641782")]
[DisplayName("Tax Information")]
public record TaxInformation2
{
    /// <summary>
    /// Tax Identification Number of the creditor.
    /// </summary>
    [IsoId("_Rvflsdp-Ed-ak6NoX_4Aeg_-297789542")]
    [DisplayName("Creditor Tax Identification")]
    [IsoXmlTag("CdtrTaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CreditorTaxIdentification { get; init; }

    /// <summary>
    /// Type of tax payer (creditor).
    /// </summary>
    [IsoId("_Rvflstp-Ed-ak6NoX_4Aeg_-299636535")]
    [DisplayName("Creditor Tax Type")]
    [IsoXmlTag("CdtrTaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CreditorTaxType { get; init; }

    /// <summary>
    /// Tax Identification Number of the debtor.
    /// </summary>
    [IsoId("_Rvfls9p-Ed-ak6NoX_4Aeg_-298710996")]
    [DisplayName("Debtor Tax Identification")]
    [IsoXmlTag("DbtrTaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DebtorTaxIdentification { get; init; }

    /// <summary>
    /// Tax reference information that is specific to a taxing agency.
    /// </summary>
    [IsoId("_RvfltNp-Ed-ak6NoX_4Aeg_-299634098")]
    [DisplayName("Tax Reference Number")]
    [IsoXmlTag("TaxRefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TaxReferenceNumber { get; init; }

    /// <summary>
    /// Total amount of money on which the tax is based.
    /// </summary>
    [IsoId("_Rvfltdp-Ed-ak6NoX_4Aeg_-298713029")]
    [DisplayName("Total Taxable Base Amount")]
    [IsoXmlTag("TtlTaxblBaseAmt")]
    public CurrencyAndAmount? TotalTaxableBaseAmount { get; init; }

    /// <summary>
    /// Amount of money resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_Rvflttp-Ed-ak6NoX_4Aeg_-298712514")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public CurrencyAndAmount? TotalTaxAmount { get; init; }

    /// <summary>
    /// Date by which tax is due.
    /// </summary>
    [IsoId("_Rvflt9p-Ed-ak6NoX_4Aeg_-1970878326")]
    [DisplayName("Tax Date")]
    [IsoXmlTag("TaxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TaxDate { get; init; }

    /// <summary>
    /// Set of characteristics defining the type of tax.
    /// </summary>
    [IsoId("_RvfluNp-Ed-ak6NoX_4Aeg_-296863056")]
    [DisplayName("Tax Type Information")]
    [IsoXmlTag("TaxTpInf")]
    public TaxDetails? TaxTypeInformation { get; init; }
}
