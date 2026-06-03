// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity of assets.
/// </summary>
[IsoId("ce1ab503-64ae-4c8e-9e59-3b70140289e7")]
[DisplayName("Quantity53")]
public record Quantity53
{
    /// <summary>
    /// Quantity of security to be transferred.
    /// </summary>
    [IsoId("2b4a6817-53f4-416d-8520-d904eaf0ff8c")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public Unit1Choice? Unit { get; init; }

    /// <summary>
    /// Percentage rate of assets to be transferred.
    /// </summary>
    [IsoId("f3f041c8-3dfb-4989-ba27-b418e9d42999")]
    [DisplayName("Percentage Rate")]
    [IsoXmlTag("PctgRate")]
    public IsoPercentageRate? PercentageRate { get; init; }

    /// <summary>
    /// Quantity expressed as an amount representing the face amount of a debt instrument.
    /// </summary>
    [IsoId("a9ba9a01-a1f4-4301-a1d1-27edb030ad22")]
    [DisplayName("Face Amount")]
    [IsoXmlTag("FaceAmt")]
    public ImpliedCurrencyAndAmount? FaceAmount { get; init; }

    /// <summary>
    /// Quantity expressed as an amount representing the current amortised face amount of a bond.
    /// </summary>
    [IsoId("6729584d-b8c5-42c8-bef4-594dc2e70c8b")]
    [DisplayName("Amortised Value")]
    [IsoXmlTag("AmtsdVal")]
    public ImpliedCurrencyAndAmount? AmortisedValue { get; init; }

    /// <summary>
    /// Cash amount to be transferred.
    /// </summary>
    [IsoId("9c656368-2e9f-4423-a152-e030f313acf1")]
    [DisplayName("Cash Amount")]
    [IsoXmlTag("CshAmt")]
    public ActiveCurrencyAnd13DecimalAmount? CashAmount { get; init; }

    /// <summary>
    /// Quantity of asset to be transferred.
    /// </summary>
    [IsoId("be70789c-d04d-4cf6-aca5-f77c610f2126")]
    [DisplayName("Other Asset")]
    [IsoXmlTag("OthrAsst")]
    public IsoMax35Text? OtherAsset { get; init; }
}
