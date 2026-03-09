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
/// Specifies the value date and the amounts traded in a foreign exchange transaction.
/// </summary>
[IsoId("_TITy0tp-Ed-ak6NoX_4Aeg_290674075")]
[DisplayName("Amounts And Value Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountsAndValueDate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountsAndValueDate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountsAndValueDate1( ActiveOrHistoricCurrencyAndAmount reqTradingSideBuyAmount,ActiveOrHistoricCurrencyAndAmount reqTradingSideSellAmount,System.DateOnly reqSettlementDate )
    {
        TradingSideBuyAmount = reqTradingSideBuyAmount;
        TradingSideSellAmount = reqTradingSideSellAmount;
        SettlementDate = reqSettlementDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency and amount bought in a foreign exchange trade.
    /// </summary>
    [IsoId("_TITy09p-Ed-ak6NoX_4Aeg_290674076")]
    [DisplayName("Trading Side Buy Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdBuyAmt")]
    #endif
    [IsoXmlTag("TradgSdBuyAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount TradingSideBuyAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount TradingSideBuyAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount TradingSideBuyAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount TradingSideBuyAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Currency and amount sold in a foreign exchange trade.
    /// </summary>
    [IsoId("_TIc8sNp-Ed-ak6NoX_4Aeg_438409417")]
    [DisplayName("Trading Side Sell Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdSellAmt")]
    #endif
    [IsoXmlTag("TradgSdSellAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount TradingSideSellAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount TradingSideSellAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount TradingSideSellAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount TradingSideSellAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the trade is settled, ie, the amounts are due.
    /// </summary>
    [IsoId("_TIc8sdp-Ed-ak6NoX_4Aeg_290674077")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate SettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly SettlementDate { get; init; } 
    #else
    public System.DateOnly SettlementDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
