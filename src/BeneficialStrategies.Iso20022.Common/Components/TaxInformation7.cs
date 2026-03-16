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
[IsoId("_Cdax17TNEeeYQd8Z9bqFog")]
[DisplayName("Tax Information")]
public record TaxInformation7
{
    /// <summary>
    /// Party on the credit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_CmIo8bTNEeeYQd8Z9bqFog")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public TaxParty1? Creditor { get; init; }

    /// <summary>
    /// Identifies the party on the debit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_CmIo87TNEeeYQd8Z9bqFog")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public TaxParty2? Debtor { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor, in this case, to the taxing authority.
    /// </summary>
    [IsoId("_CmIo9bTNEeeYQd8Z9bqFog")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public TaxParty2? UltimateDebtor { get; init; }

    /// <summary>
    /// Territorial part of a country to which the tax payment is related.
    /// </summary>
    [IsoId("_CmIo97TNEeeYQd8Z9bqFog")]
    [DisplayName("Administration Zone")]
    [IsoXmlTag("AdmstnZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdministrationZone { get; init; }

    /// <summary>
    /// Tax reference information that is specific to a taxing agency.
    /// </summary>
    [IsoId("_CmIo-bTNEeeYQd8Z9bqFog")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <summary>
    /// Method used to indicate the underlying business or how the tax is paid.
    /// </summary>
    [IsoId("_CmIo-7TNEeeYQd8Z9bqFog")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Method { get; init; }

    /// <summary>
    /// Total amount of money on which the tax is based.
    /// </summary>
    [IsoId("_CmIo_bTNEeeYQd8Z9bqFog")]
    [DisplayName("Total Taxable Base Amount")]
    [IsoXmlTag("TtlTaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; init; }

    /// <summary>
    /// Total amount of money as result of the calculation of the tax.
    /// </summary>
    [IsoId("_CmIo_7TNEeeYQd8Z9bqFog")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; init; }

    /// <summary>
    /// Date by which tax is due.
    /// </summary>
    [IsoId("_CmIpAbTNEeeYQd8Z9bqFog")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Sequential number of the tax report.
    /// </summary>
    [IsoId("_CmIpA7TNEeeYQd8Z9bqFog")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; }

    /// <summary>
    /// Record of tax details.
    /// </summary>
    [IsoId("_CmIpBbTNEeeYQd8Z9bqFog")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public TaxRecord2? Record { get; init; }
}
