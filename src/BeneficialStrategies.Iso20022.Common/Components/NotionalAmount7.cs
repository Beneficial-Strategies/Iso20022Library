// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Notional Amount7.
/// </summary>
[IsoId("_NO2ntRT0Ee61h9tfoUrWyw")]
[DisplayName("Notional Amount7")]
public record NotionalAmount7
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? Amount { get; init; }

    /// <summary>
    /// Amount In Effect.
    /// </summary>
    [DisplayName("Amount In Effect")]
    [IsoXmlTag("AmtInFct")]
    public ValueList<ActiveOrHistoricCurrencyAnd19DecimalAmount> AmountInEffect { get; init; } = [];

    /// <summary>
    /// Weighted Average Delta.
    /// </summary>
    [DisplayName("Weighted Average Delta")]
    [IsoXmlTag("WghtdAvrgDlta")]
    public IsoLongFraction19DecimalNumber? WeightedAverageDelta { get; init; }
}
