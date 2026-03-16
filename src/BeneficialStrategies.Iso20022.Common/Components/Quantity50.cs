// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity50.
/// </summary>
[IsoId("_2lB3AX_7Ee-5A_neRtHpSQ")]
[DisplayName("Quantity50")]
public record Quantity50
{
    /// <summary>
    /// Amortised Value.
    /// </summary>
    [DisplayName("Amortised Value")]
    [IsoXmlTag("AmtsdVal")]
    public ImpliedCurrencyAndAmount? AmortisedValue { get; init; }

    /// <summary>
    /// Cash Amount.
    /// </summary>
    [DisplayName("Cash Amount")]
    [IsoXmlTag("CshAmt")]
    public ActiveCurrencyAnd13DecimalAmount? CashAmount { get; init; }

    /// <summary>
    /// Face Amount.
    /// </summary>
    [DisplayName("Face Amount")]
    [IsoXmlTag("FaceAmt")]
    public ImpliedCurrencyAndAmount? FaceAmount { get; init; }

    /// <summary>
    /// Other Asset.
    /// </summary>
    [DisplayName("Other Asset")]
    [IsoXmlTag("OthrAsst")]
    public IsoMax35Text? OtherAsset { get; init; }

    /// <summary>
    /// Percentage Rate.
    /// </summary>
    [DisplayName("Percentage Rate")]
    [IsoXmlTag("PctgRate")]
    public IsoPercentageRate? PercentageRate { get; init; }

    /// <summary>
    /// Unit.
    /// </summary>
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public IsoDecimalNumber? Unit { get; init; }
}
