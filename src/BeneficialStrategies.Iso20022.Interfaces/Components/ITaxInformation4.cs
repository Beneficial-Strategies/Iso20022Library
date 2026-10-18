// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about tax paid, or to be paid, to the government in accordance with the law, including pre-defined parameters such as thresholds and type of account.
/// </summary>
[IsoId("_CoyC8aJqEeKmspP9k_hIRQ")]
public interface ITaxInformation4 : IIsoComponent
{
    /// <summary>
    /// Party on the credit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_CzEAVaJqEeKmspP9k_hIRQ")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    ITaxParty1? Creditor { get; }

    /// <summary>
    /// Identifies the party on the debit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_CzEAWaJqEeKmspP9k_hIRQ")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    ITaxParty2? Debtor { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor, in this case, to the taxing authority.
    /// </summary>
    [IsoId("_KEZf8KJqEeKmspP9k_hIRQ")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    ITaxParty2? UltimateDebtor { get; }

    /// <summary>
    /// Territorial part of a country to which the tax payment is related.
    /// </summary>
    [IsoId("_CzEAXaJqEeKmspP9k_hIRQ")]
    [DisplayName("Administration Zone")]
    [IsoXmlTag("AdmstnZone")]
    Max35Text? AdministrationZone { get; }

    /// <summary>
    /// Tax reference information that is specific to a taxing agency.
    /// </summary>
    [IsoId("_CzEAYaJqEeKmspP9k_hIRQ")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    Max140Text? ReferenceNumber { get; }

    /// <summary>
    /// Method used to indicate the underlying business or how the tax is paid.
    /// </summary>
    [IsoId("_CzEAZaJqEeKmspP9k_hIRQ")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    Max35Text? Method { get; }

    /// <summary>
    /// Total amount of money on which the tax is based.
    /// </summary>
    [IsoId("_CzEAaaJqEeKmspP9k_hIRQ")]
    [DisplayName("Total Taxable Base Amount")]
    [IsoXmlTag("TtlTaxblBaseAmt")]
    ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; }

    /// <summary>
    /// Total amount of money as result of the calculation of the tax.
    /// </summary>
    [IsoId("_CzEAbaJqEeKmspP9k_hIRQ")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; }

    /// <summary>
    /// Date by which tax is due.
    /// </summary>
    [IsoId("_CzEAcaJqEeKmspP9k_hIRQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    ISODate? Date { get; }

    /// <summary>
    /// Sequential number of the tax report.
    /// </summary>
    [IsoId("_CzEAdaJqEeKmspP9k_hIRQ")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    Number? SequenceNumber { get; }

    /// <summary>
    /// Record of tax details.
    /// </summary>
    [IsoId("_CzEAeaJqEeKmspP9k_hIRQ")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    IEnumerable<ITaxRecord1> Record { get; }
}
