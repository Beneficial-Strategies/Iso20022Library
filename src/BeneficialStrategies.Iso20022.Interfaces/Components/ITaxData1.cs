// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about tax paid, or to be paid, to the government in accordance with the law, including pre-defined parameters such as thresholds and type of account.
/// </summary>
[IsoId("_n7DtAd4lEeqt1ZcLzWyWFw")]
public interface ITaxData1 : IIsoComponent
{
    /// <summary>
    /// Party on the credit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_n9ZPQd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    ITaxParty1? Creditor { get; }

    /// <summary>
    /// Party on the debit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_n9ZPQ94lEeqt1ZcLzWyWFw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    ITaxParty2? Debtor { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor, in this case, to the taxing authority.
    /// </summary>
    [IsoId("_n9ZPRd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    ITaxParty2? UltimateDebtor { get; }

    /// <summary>
    /// Territorial part of a country to which the tax payment is related.
    /// </summary>
    [IsoId("_n9ZPR94lEeqt1ZcLzWyWFw")]
    [DisplayName("Administration Zone")]
    [IsoXmlTag("AdmstnZone")]
    Max35Text? AdministrationZone { get; }

    /// <summary>
    /// Tax reference information that is specific to a taxing agency.
    /// </summary>
    [IsoId("_n9ZPSd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    Max140Text? ReferenceNumber { get; }

    /// <summary>
    /// Method used to indicate the underlying business or how the tax is paid.
    /// </summary>
    [IsoId("_n9ZPS94lEeqt1ZcLzWyWFw")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    Max35Text? Method { get; }

    /// <summary>
    /// Total amount of money on which the tax is based.
    /// </summary>
    [IsoId("_n9ZPTd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Total Taxable Base Amount")]
    [IsoXmlTag("TtlTaxblBaseAmt")]
    ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; }

    /// <summary>
    /// Total amount of money as result of the calculation of the tax.
    /// </summary>
    [IsoId("_n9ZPT94lEeqt1ZcLzWyWFw")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; }

    /// <summary>
    /// Date by which tax is due.
    /// </summary>
    [IsoId("_n9ZPUd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    ISODate? Date { get; }

    /// <summary>
    /// Sequential number of the tax report.
    /// </summary>
    [IsoId("_n9ZPU94lEeqt1ZcLzWyWFw")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    Number? SequenceNumber { get; }

    /// <summary>
    /// Record of tax details.
    /// </summary>
    [IsoId("_n9ZPVd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    IEnumerable<ITaxRecord3> Record { get; }
}
