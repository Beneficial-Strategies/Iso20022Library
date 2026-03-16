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
[IsoId("_EIV6p5SkEeeh5JjedkaA_g")]
[DisplayName("Rate Type And Amount And Status")]
public record RateTypeAndAmountAndStatus37
{
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_EIV6qJSkEeeh5JjedkaA_g")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required DeemedRateType1Choice_ RateType { get; init; }

    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_EIV6qpSkEeeh5JjedkaA_g")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_EIV6qZSkEeeh5JjedkaA_g")]
    [DisplayName("Rate Status")]
    [IsoXmlTag("RateSts")]
    public RateStatus3Choice_? RateStatus { get; init; }
}
