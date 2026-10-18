// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxInformation8"/>
[IsoId("_wuFOYf7IEeifc-yx3AlK3Q")]
[DisplayName("Tax Information")]
public partial record TaxInformation8
{
    /// <inheritdoc cref="ITaxInformation8.Creditor"/>
    [IsoId("_w6R3U_7IEeifc-yx3AlK3Q")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public TaxParty1? Creditor { get; init; }

    /// <inheritdoc cref="ITaxInformation8.Debtor"/>
    [IsoId("_w6R3Vf7IEeifc-yx3AlK3Q")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public TaxParty2? Debtor { get; init; }

    /// <inheritdoc cref="ITaxInformation8.AdministrationZone"/>
    [IsoId("_w6R3V_7IEeifc-yx3AlK3Q")]
    [DisplayName("Administration Zone")]
    [IsoXmlTag("AdmstnZone")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdministrationZone { get; init; }

    /// <inheritdoc cref="ITaxInformation8.ReferenceNumber"/>
    [IsoId("_w6R3Wf7IEeifc-yx3AlK3Q")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ReferenceNumber { get; init; }

    /// <inheritdoc cref="ITaxInformation8.Method"/>
    [IsoId("_w6R3W_7IEeifc-yx3AlK3Q")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Method { get; init; }

    /// <inheritdoc cref="ITaxInformation8.TotalTaxableBaseAmount"/>
    [IsoId("_w6R3Xf7IEeifc-yx3AlK3Q")]
    [DisplayName("Total Taxable Base Amount")]
    [IsoXmlTag("TtlTaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxableBaseAmount { get; init; }

    /// <inheritdoc cref="ITaxInformation8.TotalTaxAmount"/>
    [IsoId("_w6R3X_7IEeifc-yx3AlK3Q")]
    [DisplayName("Total Tax Amount")]
    [IsoXmlTag("TtlTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalTaxAmount { get; init; }

    /// <inheritdoc cref="ITaxInformation8.Date"/>
    [IsoId("_w6R3Yf7IEeifc-yx3AlK3Q")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <inheritdoc cref="ITaxInformation8.SequenceNumber"/>
    [IsoId("_w6R3Y_7IEeifc-yx3AlK3Q")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; }

    /// <inheritdoc cref="ITaxInformation8.Record"/>
    [IsoId("_w6bBQf7IEeifc-yx3AlK3Q")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<TaxRecord2> Record { get; init; } = [];
}
