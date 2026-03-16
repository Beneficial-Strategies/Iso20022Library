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
[IsoId("_ckCY3JKQEeWHWpTQn1FFVg")]
[DisplayName("Rate Type And Amount And Status")]
public record RateTypeAndAmountAndStatus34
{
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_ckCY3pKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required RateType48Choice_ RateType { get; init; }

    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_ckCY5pKQEeWHWpTQn1FFVg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_ckCY6JKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Status")]
    [IsoXmlTag("RateSts")]
    public RateStatus4Choice_? RateStatus { get; init; }
}
