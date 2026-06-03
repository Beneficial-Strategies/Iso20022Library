// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statistical data related to the price change of a security.
/// </summary>
[IsoId("25810c31-9285-41f8-b37d-9e10b62aac63")]
[DisplayName("Valuation Statistics4")]
public record ValuationStatistics4
{
    [IsoId("ec2ac394-dcb0-4be1-8a98-ca76575ce5af")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveOrHistoricCurrencyCode Currency { get; init; }

    [IsoId("aef65505-1e7c-4a4f-b62b-ef85d9019fb0")]
    [DisplayName("Price Type Change Basis")]
    [IsoXmlTag("PricTpChngBsis")]
    public required PriceType2 PriceTypeChangeBasis { get; init; }

    [IsoId("7f0120fa-6dd9-4885-9f69-6192bd19237a")]
    [DisplayName("Price Change")]
    [IsoXmlTag("PricChng")]
    public required PriceValueChange1 PriceChange { get; init; }

    [IsoId("9b01ef7c-5a0a-459c-b039-c1a7d62d7822")]
    [DisplayName("Yield")]
    [IsoXmlTag("Yld")]
    public IsoPercentageRate? Yield { get; init; }

    [IsoId("c4c949e9-c9d0-4dbf-859a-06135cbcb63f")]
    [DisplayName("By Predefined Time Periods")]
    [IsoXmlTag("ByPrdfndTmPrds")]
    public StatisticsByPredefinedTimePeriods2? ByPredefinedTimePeriods { get; init; }

    [IsoId("674d68fd-1d55-47d8-b56f-ac21d02e8fa2")]
    [DisplayName("By User Defined Time Period")]
    [IsoXmlTag("ByUsrDfndTmPrd")]
    public ValueList<StatisticsByUserDefinedTimePeriod3> ByUserDefinedTimePeriod { get; init; } = [];
}
