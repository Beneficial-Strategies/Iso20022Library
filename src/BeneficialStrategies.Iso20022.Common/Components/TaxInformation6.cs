// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxInformation6"/>
[IsoId("_zSrWJ69fEeen6L7OP7lnvg")]
[DisplayName("Tax Information")]
public partial record TaxInformation6
{
    /// <inheritdoc cref="ITaxInformation6.Creditor"/>
    [IsoId("_zivyc69fEeen6L7OP7lnvg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public TaxParty1? Creditor { get; init; }

    /// <inheritdoc cref="ITaxInformation6.Debtor"/>
    [IsoId("_zivyda9fEeen6L7OP7lnvg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public TaxParty2? Debtor { get; init; }

    /// <inheritdoc cref="ITaxInformation6.AdministrationZone"/>
    [IsoId("_zivyd69fEeen6L7OP7lnvg")]
    [DisplayName("Administration Zone")]
    [IsoXmlTag("AdmstnZn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdministrationZone { get; init; }

    /// <inheritdoc cref="ITaxInformation6.ReferenceNumber"/>
    [IsoId("_zivyea9fEeen6L7OP7lnvg")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <inheritdoc cref="ITaxInformation6.Method"/>
    [IsoId("_zivye69fEeen6L7OP7lnvg")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Method { get; init; }

    /// <inheritdoc cref="ITaxInformation6.TotalTaxableBaseAmount"/>
    [IsoId("_zivyfa9fEeen6L7OP7lnvg")]
    [DisplayName("Total Taxable Base Amount")]
    [IsoXmlTag("TtlTaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; init; }

    /// <inheritdoc cref="ITaxInformation6.TotalTaxAmount"/>
    [IsoId("_zivyf69fEeen6L7OP7lnvg")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; init; }

    /// <inheritdoc cref="ITaxInformation6.Date"/>
    [IsoId("_zivyga9fEeen6L7OP7lnvg")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <inheritdoc cref="ITaxInformation6.SequenceNumber"/>
    [IsoId("_zivyg69fEeen6L7OP7lnvg")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; }

    /// <inheritdoc cref="ITaxInformation6.Record"/>
    [IsoId("_zivyha9fEeen6L7OP7lnvg")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<TaxRecord2> Record { get; init; } = [];
}
