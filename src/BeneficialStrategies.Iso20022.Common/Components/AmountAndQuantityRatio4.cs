// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio expressed as amount per quantity.
/// </summary>
[IsoId("_7mLRL0EKEeWVgfuHGaKtRQ")]
[DisplayName("Amount And Quantity Ratio")]
public record AmountAndQuantityRatio4
{
    /// <summary>
    /// Cash amount.
    /// </summary>
    [IsoId("_7y0l5UEKEeWVgfuHGaKtRQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Quantity expressed as number.
    /// </summary>
    [IsoId("_7y0l7UEKEeWVgfuHGaKtRQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Quantity { get; init; }
}
