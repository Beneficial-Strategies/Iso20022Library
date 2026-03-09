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
/// Extract of trade data for an investment fund switch order.
/// </summary>
[IsoId("_SNctANp-Ed-ak6NoX_4Aeg_1967045110")]
[DisplayName("Fund Order Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundOrderData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be redeemed.
    /// </summary>
    [IsoId("_SNctAdp-Ed-ak6NoX_4Aeg_1967045247")]
    [DisplayName("Total Redemption Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlRedAmt")]
    #endif
    [IsoXmlTag("TtlRedAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalRedemptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalRedemptionAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalRedemptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be subscribed.
    /// </summary>
    [IsoId("_SNctAtp-Ed-ak6NoX_4Aeg_1967045482")]
    [DisplayName("Total Subscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlSbcptAmt")]
    #endif
    [IsoXmlTag("TtlSbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalSubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalSubscriptionAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalSubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be transferred between the debtor and creditor before bank transaction charges.
    /// </summary>
    [IsoId("_SNctA9p-Ed-ak6NoX_4Aeg_1967045577")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("_SNctBNp-Ed-ak6NoX_4Aeg_1967965626")]
    [DisplayName("Settlement Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmMtd")]
    #endif
    [IsoXmlTag("SttlmMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryReceiptType2Code? SettlementMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryReceiptType2Code? SettlementMethod { get; init; } 
    #else
    public DeliveryReceiptType2Code? SettlementMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Additional amount of money paid by the investor in addition to the switch redemption amount.
    /// </summary>
    [IsoId("_SNctBdp-Ed-ak6NoX_4Aeg_1967965686")]
    [DisplayName("Additional Cash In")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlCshIn")]
    #endif
    [IsoXmlTag("AddtlCshIn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? AdditionalCashIn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? AdditionalCashIn { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? AdditionalCashIn { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that results from a switch-out, that is not reinvested in another investment fund, and is repaid to the investor.
    /// </summary>
    [IsoId("_SNctBtp-Ed-ak6NoX_4Aeg_1967965703")]
    [DisplayName("Resulting Cash Out")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltgCshOut")]
    #endif
    [IsoXmlTag("RsltgCshOut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ResultingCashOut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ResultingCashOut { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ResultingCashOut { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_SNctB9p-Ed-ak6NoX_4Aeg_-1694387772")]
    [DisplayName("Unit Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitCcy")]
    #endif
    [IsoXmlTag("UnitCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? UnitCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? UnitCurrency { get; init; } 
    #else
    public string? UnitCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_SNctCNp-Ed-ak6NoX_4Aeg_-1694387695")]
    [DisplayName("Quoted Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtdCcy")]
    #endif
    [IsoXmlTag("QtdCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? QuotedCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? QuotedCurrency { get; init; } 
    #else
    public string? QuotedCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
