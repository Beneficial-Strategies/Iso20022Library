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
[IsoId("_UOVmtdp-Ed-ak6NoX_4Aeg_1556182206")]
[DisplayName("Rate Type And Amount And Status")]
public record RateTypeAndAmountAndStatus5
{
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_UOVmttp-Ed-ak6NoX_4Aeg_1556183180")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required RateType10Choice_ RateType { get; init; }

    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_UOVmt9p-Ed-ak6NoX_4Aeg_1556182558")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_UOVmuNp-Ed-ak6NoX_4Aeg_1556182747")]
    [DisplayName("Rate Status")]
    [IsoXmlTag("RateSts")]
    public RateStatus1Choice_? RateStatus { get; init; }
}
