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
/// An investor&apos;s instruction to either subscribe or redeem an amount of money or its equivalent, for example, other assets, into or out of an investment fund.
/// </summary>
[IsoId("_Y0VCoThjEeamLZQeccJa7w")]
[DisplayName("Investment Funds Order Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentFundsOrderBreakdown2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentFundsOrderBreakdown2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentFundsOrderBreakdown2( OrderBreakdownType1Choice_ reqOrderBreakdownType,ActiveCurrencyAndAmount reqAmount )
    {
        OrderBreakdownType = reqOrderBreakdownType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of order breakdown.
    /// </summary>
    [IsoId("_ZN6nUzhjEeamLZQeccJa7w")]
    [DisplayName("Order Breakdown Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrBrkdwnTp")]
    #endif
    [IsoXmlTag("OrdrBrkdwnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrderBreakdownType1Choice_ OrderBreakdownType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrderBreakdownType1Choice_ OrderBreakdownType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderBreakdownType1Choice_ OrderBreakdownType { get; init; } 
    #else
    public OrderBreakdownType1Choice_ OrderBreakdownType { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the net amount that is attributed to an order type.
    /// </summary>
    [IsoId("_ZN6nVzhjEeamLZQeccJa7w")]
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
