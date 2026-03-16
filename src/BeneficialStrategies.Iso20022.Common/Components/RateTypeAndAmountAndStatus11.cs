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
[IsoId("_beyokfimEd-0JoSb983HHw")]
[DisplayName("Rate Type And Amount And Status")]
public record RateTypeAndAmountAndStatus11
{
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_beyok_imEd-0JoSb983HHw")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required RateType17Choice_ RateType { get; init; }

    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_beyolfimEd-0JoSb983HHw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_beyol_imEd-0JoSb983HHw")]
    [DisplayName("Rate Status")]
    [IsoXmlTag("RateSts")]
    public RateStatus1Choice_? RateStatus { get; init; }
}
