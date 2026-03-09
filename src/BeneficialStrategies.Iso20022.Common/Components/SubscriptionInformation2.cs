// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about cumulative subscriptions.
/// </summary>
[IsoId("_bgNQUU7dEeifNrXGwadPmg")]
[DisplayName("Subscription Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionInformation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionInformation2( System.DateOnly reqDateOfFirstSubscription,ActiveCurrencyAnd13DecimalAmount reqTotalAmountYearToDate )
    {
        DateOfFirstSubscription = reqDateOfFirstSubscription;
        TotalAmountYearToDate = reqTotalAmountYearToDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date of the first subscription in the current year.
    /// </summary>
    [IsoId("_bxBThU7dEeifNrXGwadPmg")]
    [DisplayName("Date Of First Subscription")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfFrstSbcpt")]
    #endif
    [IsoXmlTag("DtOfFrstSbcpt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate DateOfFirstSubscription { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly DateOfFirstSubscription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly DateOfFirstSubscription { get; init; } 
    #else
    public System.DateOnly DateOfFirstSubscription { get; set; } 
    #endif
    
    /// <summary>
    /// Amount subscribed in the current tax year into equities (not including dividends).
    /// </summary>
    [IsoId("_bxBTh07dEeifNrXGwadPmg")]
    [DisplayName("Equity Component")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EqtyCmpnt")]
    #endif
    [IsoXmlTag("EqtyCmpnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? EquityComponent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? EquityComponent { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? EquityComponent { get; set; } 
    #endif
    
    /// <summary>
    /// Amount subscribed in the current tax year into cash.
    /// </summary>
    [IsoId("_bxBTiU7dEeifNrXGwadPmg")]
    [DisplayName("Cash Component")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCmpnt")]
    #endif
    [IsoXmlTag("CshCmpnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? CashComponent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? CashComponent { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? CashComponent { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount subscribed in the current tax year.
    /// </summary>
    [IsoId("_bxBTi07dEeifNrXGwadPmg")]
    [DisplayName("Total Amount Year To Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtYrToDt")]
    #endif
    [IsoXmlTag("TtlAmtYrToDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAnd13DecimalAmount TotalAmountYearToDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAnd13DecimalAmount TotalAmountYearToDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount TotalAmountYearToDate { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount TotalAmountYearToDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
