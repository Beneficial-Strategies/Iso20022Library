// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the value expressed as a rate and an amount.
/// </summary>
[IsoId("_ShoBV5b9Eee8S7xwGG7Veg")]
[DisplayName("Rate Type And Amount And Status")]
public record RateTypeAndAmountAndStatus41
{
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_SwgKwZb9Eee8S7xwGG7Veg")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required RateType71Choice_ RateType { get; init; }

    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_SwgKyZb9Eee8S7xwGG7Veg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_SwgKy5b9Eee8S7xwGG7Veg")]
    [DisplayName("Rate Status")]
    [IsoXmlTag("RateSts")]
    public RateStatus3Choice_? RateStatus { get; init; }
}
