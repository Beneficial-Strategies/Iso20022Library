// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about cumulative subscriptions.
/// </summary>
[IsoId("_bgNQUU7dEeifNrXGwadPmg")]
[DisplayName("Subscription Information")]
public partial record SubscriptionInformation2
{
    #nullable enable
    
    /// <summary>
    /// Date of the first subscription in the current year.
    /// </summary>
    [IsoId("_bxBThU7dEeifNrXGwadPmg")]
    [DisplayName("Date Of First Subscription")]
    [IsoXmlTag("DtOfFrstSbcpt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate DateOfFirstSubscription { get; init; } 
    
    /// <summary>
    /// Amount subscribed in the current tax year into equities (not including dividends).
    /// </summary>
    [IsoId("_bxBTh07dEeifNrXGwadPmg")]
    [DisplayName("Equity Component")]
    [IsoXmlTag("EqtyCmpnt")]
    public ActiveCurrencyAnd13DecimalAmount? EquityComponent { get; init; } 
    
    /// <summary>
    /// Amount subscribed in the current tax year into cash.
    /// </summary>
    [IsoId("_bxBTiU7dEeifNrXGwadPmg")]
    [DisplayName("Cash Component")]
    [IsoXmlTag("CshCmpnt")]
    public ActiveCurrencyAnd13DecimalAmount? CashComponent { get; init; } 
    
    /// <summary>
    /// Total amount subscribed in the current tax year.
    /// </summary>
    [IsoId("_bxBTi07dEeifNrXGwadPmg")]
    [DisplayName("Total Amount Year To Date")]
    [IsoXmlTag("TtlAmtYrToDt")]
    public required ActiveCurrencyAnd13DecimalAmount TotalAmountYearToDate { get; init; } 
    
    
    #nullable disable
    
}
