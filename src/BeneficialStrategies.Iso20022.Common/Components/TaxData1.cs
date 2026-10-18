// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxData1"/>
[IsoId("_n7DtAd4lEeqt1ZcLzWyWFw")]
[DisplayName("Tax Data")]
public partial record TaxData1
{
    /// <inheritdoc cref="ITaxData1.Creditor"/>
    [IsoId("_n9ZPQd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public TaxParty1? Creditor { get; init; }

    /// <inheritdoc cref="ITaxData1.Debtor"/>
    [IsoId("_n9ZPQ94lEeqt1ZcLzWyWFw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public TaxParty2? Debtor { get; init; }

    /// <inheritdoc cref="ITaxData1.UltimateDebtor"/>
    [IsoId("_n9ZPRd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public TaxParty2? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ITaxData1.AdministrationZone"/>
    [IsoId("_n9ZPR94lEeqt1ZcLzWyWFw")]
    [DisplayName("Administration Zone")]
    [IsoXmlTag("AdmstnZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdministrationZone { get; init; }

    /// <inheritdoc cref="ITaxData1.ReferenceNumber"/>
    [IsoId("_n9ZPSd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <inheritdoc cref="ITaxData1.Method"/>
    [IsoId("_n9ZPS94lEeqt1ZcLzWyWFw")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Method { get; init; }

    /// <inheritdoc cref="ITaxData1.TotalTaxableBaseAmount"/>
    [IsoId("_n9ZPTd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Total Taxable Base Amount")]
    [IsoXmlTag("TtlTaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; init; }

    /// <inheritdoc cref="ITaxData1.TotalTaxAmount"/>
    [IsoId("_n9ZPT94lEeqt1ZcLzWyWFw")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; init; }

    /// <inheritdoc cref="ITaxData1.Date"/>
    [IsoId("_n9ZPUd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <inheritdoc cref="ITaxData1.SequenceNumber"/>
    [IsoId("_n9ZPU94lEeqt1ZcLzWyWFw")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; }

    /// <inheritdoc cref="ITaxData1.Record"/>
    [IsoId("_n9ZPVd4lEeqt1ZcLzWyWFw")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<TaxRecord3> Record { get; init; } = [];
}
