// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxInformation4"/>
[IsoId("_CoyC8aJqEeKmspP9k_hIRQ")]
[DisplayName("Tax Information")]
public partial record TaxInformation4
{
    /// <inheritdoc cref="ITaxInformation4.Creditor"/>
    [IsoId("_CzEAVaJqEeKmspP9k_hIRQ")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public TaxParty1? Creditor { get; init; }

    /// <inheritdoc cref="ITaxInformation4.Debtor"/>
    [IsoId("_CzEAWaJqEeKmspP9k_hIRQ")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public TaxParty2? Debtor { get; init; }

    /// <inheritdoc cref="ITaxInformation4.UltimateDebtor"/>
    [IsoId("_KEZf8KJqEeKmspP9k_hIRQ")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public TaxParty2? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ITaxInformation4.AdministrationZone"/>
    [IsoId("_CzEAXaJqEeKmspP9k_hIRQ")]
    [DisplayName("Administration Zone")]
    [IsoXmlTag("AdmstnZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdministrationZone { get; init; }

    /// <inheritdoc cref="ITaxInformation4.ReferenceNumber"/>
    [IsoId("_CzEAYaJqEeKmspP9k_hIRQ")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <inheritdoc cref="ITaxInformation4.Method"/>
    [IsoId("_CzEAZaJqEeKmspP9k_hIRQ")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Method { get; init; }

    /// <inheritdoc cref="ITaxInformation4.TotalTaxableBaseAmount"/>
    [IsoId("_CzEAaaJqEeKmspP9k_hIRQ")]
    [DisplayName("Total Taxable Base Amount")]
    [IsoXmlTag("TtlTaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; init; }

    /// <inheritdoc cref="ITaxInformation4.TotalTaxAmount"/>
    [IsoId("_CzEAbaJqEeKmspP9k_hIRQ")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; init; }

    /// <inheritdoc cref="ITaxInformation4.Date"/>
    [IsoId("_CzEAcaJqEeKmspP9k_hIRQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <inheritdoc cref="ITaxInformation4.SequenceNumber"/>
    [IsoId("_CzEAdaJqEeKmspP9k_hIRQ")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; }

    /// <inheritdoc cref="ITaxInformation4.Record"/>
    [IsoId("_CzEAeaJqEeKmspP9k_hIRQ")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<TaxRecord1> Record { get; init; } = [];
}
