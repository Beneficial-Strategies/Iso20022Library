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
[IsoId("_oDl9594lEeqt1ZcLzWyWFw")]
[DisplayName("Tax Information")]
public record TaxInformation10
{
    /// <summary>
    /// Party on the credit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_oFBhQd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public TaxParty1? Creditor { get; init; }

    /// <summary>
    /// Party on the debit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_oFBhQ94lEeqt1ZcLzWyWFw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public TaxParty2? Debtor { get; init; }

    /// <summary>
    /// Territorial part of a country to which the tax payment is related.
    /// </summary>
    [IsoId("_oFBhRd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Administration Zone")]
    [IsoXmlTag("AdmstnZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdministrationZone { get; init; }

    /// <summary>
    /// Tax reference information that is specific to a taxing agency.
    /// </summary>
    [IsoId("_oFBhR94lEeqt1ZcLzWyWFw")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <summary>
    /// Method used to indicate the underlying business or how the tax is paid.
    /// </summary>
    [IsoId("_oFBhSd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Method { get; init; }

    /// <summary>
    /// Total amount of money on which the tax is based.
    /// </summary>
    [IsoId("_oFBhS94lEeqt1ZcLzWyWFw")]
    [DisplayName("Total Taxable Base Amount")]
    [IsoXmlTag("TtlTaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; init; }

    /// <summary>
    /// Total amount of money as result of the calculation of the tax.
    /// </summary>
    [IsoId("_oFBhTd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; init; }

    /// <summary>
    /// Date by which tax is due.
    /// </summary>
    [IsoId("_oFBhT94lEeqt1ZcLzWyWFw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Sequential number of the tax report.
    /// </summary>
    [IsoId("_oFBhUd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; }

    /// <summary>
    /// Record of tax details.
    /// </summary>
    [IsoId("_oFBhU94lEeqt1ZcLzWyWFw")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<TaxRecord3> Record { get; init; } = [];
}
