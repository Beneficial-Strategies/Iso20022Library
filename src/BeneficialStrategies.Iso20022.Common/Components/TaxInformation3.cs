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
[IsoId("_Rv8Rotp-Ed-ak6NoX_4Aeg_1538842509")]
[DisplayName("Tax Information")]
public record TaxInformation3
{
    /// <summary>
    /// Party on the credit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_Rv8Ro9p-Ed-ak6NoX_4Aeg_-1553700476")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public TaxParty1? Creditor { get; init; }

    /// <summary>
    /// Set of elements used to identify the party on the debit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_Rv8RpNp-Ed-ak6NoX_4Aeg_-1501060489")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public TaxParty2? Debtor { get; init; }

    /// <summary>
    /// Territorial part of a country to which the tax payment is related.
    /// </summary>
    [IsoId("_Rv8Rpdp-Ed-ak6NoX_4Aeg_1607923287")]
    [DisplayName("Administration Zone")]
    [IsoXmlTag("AdmstnZn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdministrationZone { get; init; }

    /// <summary>
    /// Tax reference information that is specific to a taxing agency.
    /// </summary>
    [IsoId("_Rv8Rptp-Ed-ak6NoX_4Aeg_1538842570")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <summary>
    /// Method used to indicate the underlying business or how the tax is paid.
    /// </summary>
    [IsoId("_Rv8Rp9p-Ed-ak6NoX_4Aeg_1836342968")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Method { get; init; }

    /// <summary>
    /// Total amount of money on which the tax is based.
    /// </summary>
    [IsoId("_Rv8RqNp-Ed-ak6NoX_4Aeg_1538842601")]
    [DisplayName("Total Taxable Base Amount")]
    [IsoXmlTag("TtlTaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; init; }

    /// <summary>
    /// Total amount of money as result of the calculation of the tax.
    /// </summary>
    [IsoId("_RwGCoNp-Ed-ak6NoX_4Aeg_1538842632")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; init; }

    /// <summary>
    /// Date by which tax is due.
    /// </summary>
    [IsoId("_RwGCodp-Ed-ak6NoX_4Aeg_1538842662")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Sequential number of the tax report.
    /// </summary>
    [IsoId("_RwGCotp-Ed-ak6NoX_4Aeg_-794505042")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; }

    /// <summary>
    /// Record of tax details.
    /// </summary>
    [IsoId("_RwGCo9p-Ed-ak6NoX_4Aeg_1538843017")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public TaxRecord1? Record { get; init; }
}
