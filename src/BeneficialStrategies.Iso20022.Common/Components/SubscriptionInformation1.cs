// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a subscription order.
/// </summary>
[IsoId("_R5oZItp-Ed-ak6NoX_4Aeg_376487239")]
[DisplayName("Subscription Information")]
public record SubscriptionInformation1
{
    /// <summary>
    /// Date the investment plan starts.
    /// </summary>
    [IsoId("_R5oZI9p-Ed-ak6NoX_4Aeg_376487265")]
    [DisplayName("Date Of First Subscription")]
    [IsoXmlTag("DtOfFrstSbcpt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate DateOfFirstSubscription { get; init; }

    /// <summary>
    /// Amount subscribed in the current tax year into equity (not including dividends).
    /// </summary>
    [IsoId("_R5oZJNp-Ed-ak6NoX_4Aeg_376487316")]
    [DisplayName("Equity Component")]
    [IsoXmlTag("EqtyCmpnt")]
    public ActiveCurrencyAndAmount? EquityComponent { get; init; }

    /// <summary>
    /// Amount subscribed in the current tax year into cash.
    /// </summary>
    [IsoId("_R5oZJdp-Ed-ak6NoX_4Aeg_376487334")]
    [DisplayName("Cash Component")]
    [IsoXmlTag("CshCmpnt")]
    public ActiveCurrencyAndAmount? CashComponent { get; init; }

    /// <summary>
    /// Total amount subscribed in the current tax year.
    /// </summary>
    [IsoId("_R5oZJtp-Ed-ak6NoX_4Aeg_376487299")]
    [DisplayName("Total Amount Year To Date")]
    [IsoXmlTag("TtlAmtYrToDt")]
    public required ActiveCurrencyAndAmount TotalAmountYearToDate { get; init; }
}
