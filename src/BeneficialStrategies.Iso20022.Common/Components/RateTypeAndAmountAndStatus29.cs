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
[IsoId("_XrJfF0EIEeWVgfuHGaKtRQ")]
[DisplayName("Rate Type And Amount And Status")]
public record RateTypeAndAmountAndStatus29
{
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_X3f480EIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required RateType39Choice_ RateType { get; init; }

    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_X3f4-0EIEeWVgfuHGaKtRQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_X3f4_UEIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Status")]
    [IsoXmlTag("RateSts")]
    public RateStatus3Choice_? RateStatus { get; init; }
}
