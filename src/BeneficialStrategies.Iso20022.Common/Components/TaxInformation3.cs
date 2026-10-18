// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxInformation3"/>
[IsoId("_Rv8Rotp-Ed-ak6NoX_4Aeg_1538842509")]
[DisplayName("Tax Information")]
public partial record TaxInformation3
{
    /// <inheritdoc cref="ITaxInformation3.Creditor"/>
    [IsoId("_Rv8Ro9p-Ed-ak6NoX_4Aeg_-1553700476")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public TaxParty1? Creditor { get; init; }

    /// <inheritdoc cref="ITaxInformation3.Debtor"/>
    [IsoId("_Rv8RpNp-Ed-ak6NoX_4Aeg_-1501060489")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public TaxParty2? Debtor { get; init; }

    /// <inheritdoc cref="ITaxInformation3.AdministrationZone"/>
    [IsoId("_Rv8Rpdp-Ed-ak6NoX_4Aeg_1607923287")]
    [DisplayName("Administration Zone")]
    [IsoXmlTag("AdmstnZn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdministrationZone { get; init; }

    /// <inheritdoc cref="ITaxInformation3.ReferenceNumber"/>
    [IsoId("_Rv8Rptp-Ed-ak6NoX_4Aeg_1538842570")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <inheritdoc cref="ITaxInformation3.Method"/>
    [IsoId("_Rv8Rp9p-Ed-ak6NoX_4Aeg_1836342968")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Method { get; init; }

    /// <inheritdoc cref="ITaxInformation3.TotalTaxableBaseAmount"/>
    [IsoId("_Rv8RqNp-Ed-ak6NoX_4Aeg_1538842601")]
    [DisplayName("Total Taxable Base Amount")]
    [IsoXmlTag("TtlTaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; init; }

    /// <inheritdoc cref="ITaxInformation3.TotalTaxAmount"/>
    [IsoId("_RwGCoNp-Ed-ak6NoX_4Aeg_1538842632")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; init; }

    /// <inheritdoc cref="ITaxInformation3.Date"/>
    [IsoId("_RwGCodp-Ed-ak6NoX_4Aeg_1538842662")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <inheritdoc cref="ITaxInformation3.SequenceNumber"/>
    [IsoId("_RwGCotp-Ed-ak6NoX_4Aeg_-794505042")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; }

    /// <inheritdoc cref="ITaxInformation3.Record"/>
    [IsoId("_RwGCo9p-Ed-ak6NoX_4Aeg_1538843017")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<TaxRecord1> Record { get; init; } = [];
}
