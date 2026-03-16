// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// An investor&apos;s instruction to either subscribe or redeem an amount of money or its equivalent, eg, other assets, into or out of an investment fund.
/// </summary>
[IsoId("_TSS1NNp-Ed-ak6NoX_4Aeg_2044308495")]
[DisplayName("Investment Funds Order Breakdown")]
public record InvestmentFundsOrderBreakdown1
{
    /// <summary>
    /// Type of order breakdown.
    /// </summary>
    [IsoId("_TSS1Ndp-Ed-ak6NoX_4Aeg_-1812911324")]
    [DisplayName("Order Breakdown Type")]
    [IsoXmlTag("OrdrBrkdwnTp")]
    public required FundOrderType5Code OrderBreakdownType { get; init; }

    /// <summary>
    /// Type of order breakdown.
    /// </summary>
    [IsoId("_TSS1Ntp-Ed-ak6NoX_4Aeg_-1531234336")]
    [DisplayName("Extended Order Breakdown Type")]
    [IsoXmlTag("XtndedOrdrBrkdwnTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedOrderBreakdownType { get; init; }

    /// <summary>
    /// Portion of the net amount that is attributed to an order type.
    /// </summary>
    [IsoId("_TSS1N9p-Ed-ak6NoX_4Aeg_-1558018521")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }
}
