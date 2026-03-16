// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// An investor&apos;s instruction to either subscribe or redeem an amount of money or its equivalent, for example, other assets, into or out of an investment fund.
/// </summary>
[IsoId("_Y0VCoThjEeamLZQeccJa7w")]
[DisplayName("Investment Funds Order Breakdown")]
public record InvestmentFundsOrderBreakdown2
{
    /// <summary>
    /// Type of order breakdown.
    /// </summary>
    [IsoId("_ZN6nUzhjEeamLZQeccJa7w")]
    [DisplayName("Order Breakdown Type")]
    [IsoXmlTag("OrdrBrkdwnTp")]
    public required OrderBreakdownType1Choice_ OrderBreakdownType { get; init; }

    /// <summary>
    /// Portion of the net amount that is attributed to an order type.
    /// </summary>
    [IsoId("_ZN6nVzhjEeamLZQeccJa7w")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }
}
