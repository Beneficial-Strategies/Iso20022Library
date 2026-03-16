// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Position Set Total2.
/// </summary>
[IsoId("_7LI85RTuEe61h9tfoUrWyw")]
[DisplayName("Position Set Total2")]
public record PositionSetTotal2
{
    /// <summary>
    /// Negative Value.
    /// </summary>
    [DisplayName("Negative Value")]
    [IsoXmlTag("NegVal")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? NegativeValue { get; init; }

    /// <summary>
    /// Notional.
    /// </summary>
    [DisplayName("Notional")]
    [IsoXmlTag("Ntnl")]
    public NotionalAmountLegs6? Notional { get; init; }

    /// <summary>
    /// Number Of Trades.
    /// </summary>
    [DisplayName("Number Of Trades")]
    [IsoXmlTag("NbOfTrds")]
    public IsoMax20PositiveNumber? NumberOfTrades { get; init; }

    /// <summary>
    /// Other Payment Amount.
    /// </summary>
    [DisplayName("Other Payment Amount")]
    [IsoXmlTag("OthrPmtAmt")]
    public ValueList<ActiveOrHistoricCurrencyAnd19DecimalAmount> OtherPaymentAmount { get; init; } =
        [];

    /// <summary>
    /// Positive Value.
    /// </summary>
    [DisplayName("Positive Value")]
    [IsoXmlTag("PostvVal")]
    public ActiveOrHistoricCurrencyAnd19DecimalAmount? PositiveValue { get; init; }
}
