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
[IsoId("_UOMcwNp-Ed-ak6NoX_4Aeg_1551032160")]
[DisplayName("Rate Type And Amount And Status")]
public record RateTypeAndAmountAndStatus6
{
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_UOMcwdp-Ed-ak6NoX_4Aeg_1551033398")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required RateType11Choice_ RateType { get; init; }

    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_UOMcwtp-Ed-ak6NoX_4Aeg_1551032469")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_UOMcw9p-Ed-ak6NoX_4Aeg_1551032667")]
    [DisplayName("Rate Status")]
    [IsoXmlTag("RateSts")]
    public RateStatus1Choice_? RateStatus { get; init; }
}
