// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about tax paid, or to be paid, to the government in accordance with the law, including pre-defined parameters such as thresholds and type of account.
/// </summary>
[IsoId("_zSrWJ69fEeen6L7OP7lnvg")]
public interface ITaxInformation6 : IIsoComponent
{
    /// <summary>
    /// Party on the credit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_zivyc69fEeen6L7OP7lnvg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    ITaxParty1? Creditor { get; }

    /// <summary>
    /// Set of elements used to identify the party on the debit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_zivyda9fEeen6L7OP7lnvg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    ITaxParty2? Debtor { get; }

    /// <summary>
    /// Territorial part of a country to which the tax payment is related.
    /// </summary>
    [IsoId("_zivyd69fEeen6L7OP7lnvg")]
    [DisplayName("Administration Zone")]
    [IsoXmlTag("AdmstnZn")]
    Max35Text? AdministrationZone { get; }

    /// <summary>
    /// Tax reference information that is specific to a taxing agency.
    /// </summary>
    [IsoId("_zivyea9fEeen6L7OP7lnvg")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    Max140Text? ReferenceNumber { get; }

    /// <summary>
    /// Method used to indicate the underlying business or how the tax is paid.
    /// </summary>
    [IsoId("_zivye69fEeen6L7OP7lnvg")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    Max35Text? Method { get; }

    /// <summary>
    /// Total amount of money on which the tax is based.
    /// </summary>
    [IsoId("_zivyfa9fEeen6L7OP7lnvg")]
    [DisplayName("Total Taxable Base Amount")]
    [IsoXmlTag("TtlTaxblBaseAmt")]
    ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; }

    /// <summary>
    /// Total amount of money as result of the calculation of the tax.
    /// </summary>
    [IsoId("_zivyf69fEeen6L7OP7lnvg")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; }

    /// <summary>
    /// Date by which tax is due.
    /// </summary>
    [IsoId("_zivyga9fEeen6L7OP7lnvg")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    ISODate? Date { get; }

    /// <summary>
    /// Sequential number of the tax report.
    /// </summary>
    [IsoId("_zivyg69fEeen6L7OP7lnvg")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    Number? SequenceNumber { get; }

    /// <summary>
    /// Record of tax details.
    /// </summary>
    [IsoId("_zivyha9fEeen6L7OP7lnvg")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    IEnumerable<ITaxRecord2> Record { get; }
}
