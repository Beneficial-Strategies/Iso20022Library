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
[IsoId("_wsgl8QVUEeq4ZaI1b_-GPA")]
[DisplayName("Quantity")]
public record Quantity47
{
    /// <summary>
    /// Quantity of security to be transferred.
    /// </summary>
    [IsoId("_xCEmQQVUEeq4ZaI1b_-GPA")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Unit { get; init; }

    /// <summary>
    /// Percentage rate of assets to be transferred.
    /// </summary>
    [IsoId("_xCEmQwVUEeq4ZaI1b_-GPA")]
    [DisplayName("Percentage Rate")]
    [IsoXmlTag("PctgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageRate { get; init; }

    /// <summary>
    /// Quantity expressed as an amount representing the face amount, that is, the principal, of a debt instrument.
    /// </summary>
    [IsoId("_xCEmRQVUEeq4ZaI1b_-GPA")]
    [DisplayName("Face Amount")]
    [IsoXmlTag("FaceAmt")]
    public ImpliedCurrencyAndAmount? FaceAmount { get; init; }

    /// <summary>
    /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond&apos;s principal amount.
    /// </summary>
    [IsoId("_xCEmRwVUEeq4ZaI1b_-GPA")]
    [DisplayName("Amortised Value")]
    [IsoXmlTag("AmtsdVal")]
    public ImpliedCurrencyAndAmount? AmortisedValue { get; init; }

    /// <summary>
    /// Cash amount to be transferred.
    /// </summary>
    [IsoId("_xCEmSQVUEeq4ZaI1b_-GPA")]
    [DisplayName("Cash Amount")]
    [IsoXmlTag("CshAmt")]
    public ActiveCurrencyAnd13DecimalAmount? CashAmount { get; init; }

    /// <summary>
    /// Quantity of asset to be transferred.
    /// </summary>
    [IsoId("_xCEmSwVUEeq4ZaI1b_-GPA")]
    [DisplayName("Other Asset")]
    [IsoXmlTag("OthrAsst")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherAsset { get; init; }
}
