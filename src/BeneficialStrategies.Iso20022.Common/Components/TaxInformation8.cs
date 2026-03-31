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
[IsoId("_wuFOYf7IEeifc-yx3AlK3Q")]
[DisplayName("Tax Information")]
public record TaxInformation8
{
    /// <summary>
    /// Party on the credit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_w6R3U_7IEeifc-yx3AlK3Q")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public TaxParty1? Creditor { get; init; }

    /// <summary>
    /// Party on the debit side of the transaction to which the tax applies.
    /// </summary>
    [IsoId("_w6R3Vf7IEeifc-yx3AlK3Q")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public TaxParty2? Debtor { get; init; }

    /// <summary>
    /// Territorial part of a country to which the tax payment is related.
    /// </summary>
    [IsoId("_w6R3V_7IEeifc-yx3AlK3Q")]
    [DisplayName("Administration Zone")]
    [IsoXmlTag("AdmstnZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdministrationZone { get; init; }

    /// <summary>
    /// Tax reference information that is specific to a taxing agency.
    /// </summary>
    [IsoId("_w6R3Wf7IEeifc-yx3AlK3Q")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <summary>
    /// Method used to indicate the underlying business or how the tax is paid.
    /// </summary>
    [IsoId("_w6R3W_7IEeifc-yx3AlK3Q")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Method { get; init; }

    /// <summary>
    /// Total amount of money on which the tax is based.
    /// </summary>
    [IsoId("_w6R3Xf7IEeifc-yx3AlK3Q")]
    [DisplayName("Total Taxable Base Amount")]
    [IsoXmlTag("TtlTaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; init; }

    /// <summary>
    /// Total amount of money as result of the calculation of the tax.
    /// </summary>
    [IsoId("_w6R3X_7IEeifc-yx3AlK3Q")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; init; }

    /// <summary>
    /// Date by which tax is due.
    /// </summary>
    [IsoId("_w6R3Yf7IEeifc-yx3AlK3Q")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Sequential number of the tax report.
    /// </summary>
    [IsoId("_w6R3Y_7IEeifc-yx3AlK3Q")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; }

    /// <summary>
    /// Record of tax details.
    /// </summary>
    [IsoId("_w6bBQf7IEeifc-yx3AlK3Q")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<TaxRecord2> Record { get; init; } = [];
}
