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
/// Execution of a subscription order.
/// </summary>
[IsoId("_R5oZItp-Ed-ak6NoX_4Aeg_376487239")]
[DisplayName("Subscription Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionInformation1( System.DateOnly reqDateOfFirstSubscription,ActiveCurrencyAndAmount reqTotalAmountYearToDate )
    {
        DateOfFirstSubscription = reqDateOfFirstSubscription;
        TotalAmountYearToDate = reqTotalAmountYearToDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date the investment plan starts.
    /// </summary>
    [IsoId("_R5oZI9p-Ed-ak6NoX_4Aeg_376487265")]
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
    /// Amount subscribed in the current tax year into equity (not including dividends).
    /// </summary>
    [IsoId("_R5oZJNp-Ed-ak6NoX_4Aeg_376487316")]
    [DisplayName("Equity Component")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EqtyCmpnt")]
    #endif
    [IsoXmlTag("EqtyCmpnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? EquityComponent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? EquityComponent { get; init; } 
    #else
    public ActiveCurrencyAndAmount? EquityComponent { get; set; } 
    #endif
    
    /// <summary>
    /// Amount subscribed in the current tax year into cash.
    /// </summary>
    [IsoId("_R5oZJdp-Ed-ak6NoX_4Aeg_376487334")]
    [DisplayName("Cash Component")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCmpnt")]
    #endif
    [IsoXmlTag("CshCmpnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CashComponent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CashComponent { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CashComponent { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount subscribed in the current tax year.
    /// </summary>
    [IsoId("_R5oZJtp-Ed-ak6NoX_4Aeg_376487299")]
    [DisplayName("Total Amount Year To Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtYrToDt")]
    #endif
    [IsoXmlTag("TtlAmtYrToDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TotalAmountYearToDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TotalAmountYearToDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TotalAmountYearToDate { get; init; } 
    #else
    public ActiveCurrencyAndAmount TotalAmountYearToDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
