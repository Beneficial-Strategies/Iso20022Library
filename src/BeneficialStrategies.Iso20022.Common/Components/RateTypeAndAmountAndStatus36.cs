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
[IsoId("_ckN-w5KQEeWHWpTQn1FFVg")]
[DisplayName("Rate Type And Amount And Status")]
public record RateTypeAndAmountAndStatus36
{
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_ckN-xZKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required RateType50Choice_ RateType { get; init; }

    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_ckN-zZKQEeWHWpTQn1FFVg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_ckN-z5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Status")]
    [IsoXmlTag("RateSts")]
    public RateStatus4Choice_? RateStatus { get; init; }
}
