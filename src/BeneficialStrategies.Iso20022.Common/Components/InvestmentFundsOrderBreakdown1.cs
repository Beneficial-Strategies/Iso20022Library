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
/// An investor&apos;s instruction to either subscribe or redeem an amount of money or its equivalent, eg, other assets, into or out of an investment fund.
/// </summary>
[IsoId("_TSS1NNp-Ed-ak6NoX_4Aeg_2044308495")]
[DisplayName("Investment Funds Order Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentFundsOrderBreakdown1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentFundsOrderBreakdown1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentFundsOrderBreakdown1( FundOrderType5Code reqOrderBreakdownType,System.String reqExtendedOrderBreakdownType,ActiveCurrencyAndAmount reqAmount )
    {
        OrderBreakdownType = reqOrderBreakdownType;
        ExtendedOrderBreakdownType = reqExtendedOrderBreakdownType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of order breakdown.
    /// </summary>
    [IsoId("_TSS1Ndp-Ed-ak6NoX_4Aeg_-1812911324")]
    [DisplayName("Order Breakdown Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrBrkdwnTp")]
    #endif
    [IsoXmlTag("OrdrBrkdwnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FundOrderType5Code OrderBreakdownType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FundOrderType5Code OrderBreakdownType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundOrderType5Code OrderBreakdownType { get; init; } 
    #else
    public FundOrderType5Code OrderBreakdownType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of order breakdown.
    /// </summary>
    [IsoId("_TSS1Ntp-Ed-ak6NoX_4Aeg_-1531234336")]
    [DisplayName("Extended Order Breakdown Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedOrdrBrkdwnTp")]
    #endif
    [IsoXmlTag("XtndedOrdrBrkdwnTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedOrderBreakdownType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedOrderBreakdownType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedOrderBreakdownType { get; init; } 
    #else
    public System.String ExtendedOrderBreakdownType { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the net amount that is attributed to an order type.
    /// </summary>
    [IsoId("_TSS1N9p-Ed-ak6NoX_4Aeg_-1558018521")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
