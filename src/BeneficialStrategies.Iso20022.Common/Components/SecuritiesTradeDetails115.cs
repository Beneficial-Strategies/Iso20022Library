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
/// Details of the securities trade.
/// </summary>
[IsoId("_IaUdwQmNEeuQ1MenzX1l-g")]
[DisplayName("Securities Trade Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesTradeDetails115
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesTradeDetails115 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesTradeDetails115( SettlementDate18Choice_ reqEffectiveSettlementDate )
    {
        EffectiveSettlementDate = reqEffectiveSettlementDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_IpWYSwmNEeuQ1MenzX1l-g")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; } 
    #else
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("_IpWYTwmNEeuQ1MenzX1l-g")]
    [DisplayName("Place Of Clearing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfClr")]
    #endif
    [IsoXmlTag("PlcOfClr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; } 
    #else
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_IpWYUwmNEeuQ1MenzX1l-g")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeDate8Choice_? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDate8Choice_? TradeDate { get; init; } 
    #else
    public TradeDate8Choice_? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_IpWYVwmNEeuQ1MenzX1l-g")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementDate17Choice_? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDate17Choice_? SettlementDate { get; init; } 
    #else
    public SettlementDate17Choice_? SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which a transaction is completed and cleared, that is, payment is effected and securities are delivered.
    /// </summary>
    [IsoId("_IpWYWQmNEeuQ1MenzX1l-g")]
    [DisplayName("Effective Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvSttlmDt")]
    #endif
    [IsoXmlTag("FctvSttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDate18Choice_ EffectiveSettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementDate18Choice_ EffectiveSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDate18Choice_ EffectiveSettlementDate { get; init; } 
    #else
    public SettlementDate18Choice_ EffectiveSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    [IsoId("_IpWYWwmNEeuQ1MenzX1l-g")]
    [DisplayName("Deal Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealPric")]
    #endif
    [IsoXmlTag("DealPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price10? DealPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price10? DealPrice { get; init; } 
    #else
    public Price10? DealPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    [IsoId("_IpWYXwmNEeuQ1MenzX1l-g")]
    [DisplayName("Reporting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rptg")]
    #endif
    [IsoXmlTag("Rptg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reporting6Choice_? Reporting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reporting6Choice_? Reporting { get; init; } 
    #else
    public Reporting6Choice_? Reporting { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_IpWYYwmNEeuQ1MenzX1l-g")]
    [DisplayName("Number Of Days Accrued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDaysAcrd")]
    #endif
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Number? NumberOfDaysAccrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfDaysAccrued { get; init; } 
    #else
    public System.UInt64? NumberOfDaysAccrued { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_IpWYZwmNEeuQ1MenzX1l-g")]
    [DisplayName("Trade Transaction Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradTxCond")]
    #endif
    [IsoXmlTag("TradTxCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeTransactionCondition5Choice_? TradeTransactionCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransactionCondition5Choice_? TradeTransactionCondition { get; init; } 
    #else
    public TradeTransactionCondition5Choice_? TradeTransactionCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the role of the investor in the transaction.
    /// </summary>
    [IsoId("_IpWYawmNEeuQ1MenzX1l-g")]
    [DisplayName("Investor Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrCpcty")]
    #endif
    [IsoXmlTag("InvstrCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorCapacity4Choice_? InvestorCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorCapacity4Choice_? InvestorCapacity { get; init; } 
    #else
    public InvestorCapacity4Choice_? InvestorCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    [IsoId("_IpWYbwmNEeuQ1MenzX1l-g")]
    [DisplayName("Trade Originator Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradOrgtrRole")]
    #endif
    [IsoXmlTag("TradOrgtrRole")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeOriginator3Choice_? TradeOriginatorRole { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeOriginator3Choice_? TradeOriginatorRole { get; init; } 
    #else
    public TradeOriginator3Choice_? TradeOriginatorRole { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional settlement processing information which cannot be included within the structured fields of the message.
    /// </summary>
    [IsoId("_IpWYcwmNEeuQ1MenzX1l-g")]
    [DisplayName("Settlement Instruction Processing Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmInstrPrcgAddtlDtls")]
    #endif
    [IsoXmlTag("SttlmInstrPrcgAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    #else
    public System.String? SettlementInstructionProcessingAdditionalDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional details pertaining to foreign exchange instructions.
    /// </summary>
    [IsoId("_IpWYdwmNEeuQ1MenzX1l-g")]
    [DisplayName("FX Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxAddtlDtls")]
    #endif
    [IsoXmlTag("FxAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? FXAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FXAdditionalDetails { get; init; } 
    #else
    public System.String? FXAdditionalDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
