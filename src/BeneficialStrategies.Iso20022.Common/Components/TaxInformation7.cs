// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxInformation7"/>
[IsoId("_Cdax17TNEeeYQd8Z9bqFog")]
[DisplayName("Tax Information")]
public partial record TaxInformation7
{
    /// <inheritdoc cref="ITaxInformation7.Creditor"/>
    [IsoId("_CmIo8bTNEeeYQd8Z9bqFog")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public TaxParty1? Creditor { get; init; }

    /// <inheritdoc cref="ITaxInformation7.Debtor"/>
    [IsoId("_CmIo87TNEeeYQd8Z9bqFog")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public TaxParty2? Debtor { get; init; }

    /// <inheritdoc cref="ITaxInformation7.UltimateDebtor"/>
    [IsoId("_CmIo9bTNEeeYQd8Z9bqFog")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public TaxParty2? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ITaxInformation7.AdministrationZone"/>
    [IsoId("_CmIo97TNEeeYQd8Z9bqFog")]
    [DisplayName("Administration Zone")]
    [IsoXmlTag("AdmstnZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdministrationZone { get; init; }

    /// <inheritdoc cref="ITaxInformation7.ReferenceNumber"/>
    [IsoId("_CmIo-bTNEeeYQd8Z9bqFog")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <inheritdoc cref="ITaxInformation7.Method"/>
    [IsoId("_CmIo-7TNEeeYQd8Z9bqFog")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Method { get; init; }

    /// <inheritdoc cref="ITaxInformation7.TotalTaxableBaseAmount"/>
    [IsoId("_CmIo_bTNEeeYQd8Z9bqFog")]
    [DisplayName("Total Taxable Base Amount")]
    [IsoXmlTag("TtlTaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; init; }

    /// <inheritdoc cref="ITaxInformation7.TotalTaxAmount"/>
    [IsoId("_CmIo_7TNEeeYQd8Z9bqFog")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; init; }

    /// <inheritdoc cref="ITaxInformation7.Date"/>
    [IsoId("_CmIpAbTNEeeYQd8Z9bqFog")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <inheritdoc cref="ITaxInformation7.SequenceNumber"/>
    [IsoId("_CmIpA7TNEeeYQd8Z9bqFog")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; }

    /// <inheritdoc cref="ITaxInformation7.Record"/>
    [IsoId("_CmIpBbTNEeeYQd8Z9bqFog")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<TaxRecord2> Record { get; init; } = [];
}
