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
/// Extract of trade data for an investment fund order.
/// </summary>
[IsoId("_JSDipTbtEead9bDRE_1DAQ")]
[DisplayName("Fund Order Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundOrderData5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Account information of the individual order instruction for which the status is given.
    /// </summary>
    [IsoId("_JrNCUTbtEead9bDRE_1DAQ")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount58? InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount58? InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount58? InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument information of the individual order instruction for which the status is given.
    /// </summary>
    [IsoId("_JrNCUzbtEead9bDRE_1DAQ")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument57? FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument57? FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument57? FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Number of investment fund units subscribed or redeemed.
    /// </summary>
    [IsoId("_JrNCVTbtEead9bDRE_1DAQ")]
    [DisplayName("Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsNb")]
    #endif
    [IsoXmlTag("UnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? UnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? UnitsNumber { get; init; } 
    #else
    public System.UInt64? UnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// When the status message is used for a subscription, this is the amount of money to be invested in the fund. 
    /// Net Amount = Quantity * Price.
    /// When the status message is used for a redemption, this is the amount of money to be received following redemption of fund units. 
    /// Net Amount = (Quantity * Price) - (Fees + Taxes).
    /// </summary>
    [IsoId("_JrNCVzbtEead9bDRE_1DAQ")]
    [DisplayName("Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetAmt")]
    #endif
    [IsoXmlTag("NetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// When the status message is used for a subscription, this is the amount of money to be paid by the investor when subscribing to fund units. 
    /// Gross amount = (Quantity * Price) + (Fees + Taxes). 
    /// When the status message is used for a redemption, this is the amount of money to be redeemed from the fund. 
    /// Gross Amount = Quantity * Price.
    /// </summary>
    [IsoId("_JrNCWTbtEead9bDRE_1DAQ")]
    [DisplayName("Gross Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssAmt")]
    #endif
    [IsoXmlTag("GrssAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Portion of the investor&apos;s holdings, in a specific investment fund/fund class, that is redeemed.
    /// </summary>
    [IsoId("_JrNCWzbtEead9bDRE_1DAQ")]
    [DisplayName("Holdings Redemption Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgsRedRate")]
    #endif
    [IsoXmlTag("HldgsRedRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? HoldingsRedemptionRate { get; init; } 
    #else
    public System.Decimal? HoldingsRedemptionRate { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_JrWMQTbtEead9bDRE_1DAQ")]
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
    /// Currency from which the quoted currency is converted in an exchange rate calculation.
    /// 1 x &lt;UnitCcy&gt; = &lt;XchgRate&gt; x &lt;QtdCcy&gt;.
    /// </summary>
    [IsoId("_JrWMQzbtEead9bDRE_1DAQ")]
    [DisplayName("Unit Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitCcy")]
    #endif
    [IsoXmlTag("UnitCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? UnitCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? UnitCurrency { get; init; } 
    #else
    public string? UnitCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency into which the unit currency is converted in an exchange rate calculation.
    /// 1 x &lt;UnitCcy&gt; = &lt;XchgRate&gt; x &lt;QtdCcy&gt;.
    /// </summary>
    [IsoId("_JrWMRTbtEead9bDRE_1DAQ")]
    [DisplayName("Quoted Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtdCcy")]
    #endif
    [IsoXmlTag("QtdCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? QuotedCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? QuotedCurrency { get; init; } 
    #else
    public string? QuotedCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
