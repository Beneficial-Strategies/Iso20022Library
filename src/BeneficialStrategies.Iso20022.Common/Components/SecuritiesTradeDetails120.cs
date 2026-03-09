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
[IsoId("__fex0QyOEeuG8M5giQ2e0w")]
[DisplayName("Securities Trade Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesTradeDetails120
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [IsoId("__vsYHwyOEeuG8M5giQ2e0w")]
    [DisplayName("Trade Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradId")]
    #endif
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? TradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradeIdentification { get; init; } 
    #else
    public System.String? TradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of a collateral transaction as assigned by the instructing party.
    /// </summary>
    [IsoId("__vsYIwyOEeuG8M5giQ2e0w")]
    [DisplayName("Collateral Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollTxId")]
    #endif
    [IsoXmlTag("CollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CollateralTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralTransactionIdentification { get; init; } 
    #else
    public System.String? CollateralTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("__vsYJwyOEeuG8M5giQ2e0w")]
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
    [IsoId("__vsYKwyOEeuG8M5giQ2e0w")]
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
    [IsoId("__vsYLwyOEeuG8M5giQ2e0w")]
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
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    [IsoId("__vsYMwyOEeuG8M5giQ2e0w")]
    [DisplayName("Late Delivery Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LateDlvryDt")]
    #endif
    [IsoXmlTag("LateDlvryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? LateDeliveryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? LateDeliveryDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? LateDeliveryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    [IsoId("__vsYNwyOEeuG8M5giQ2e0w")]
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
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("__vsYOwyOEeuG8M5giQ2e0w")]
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
    /// Specifies additional information relative to the processing of the trade.
    /// </summary>
    [IsoId("__vsYPwyOEeuG8M5giQ2e0w")]
    [DisplayName("Opening Closing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngClsg")]
    #endif
    [IsoXmlTag("OpngClsg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OpeningClosing3Choice_? OpeningClosing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OpeningClosing3Choice_? OpeningClosing { get; init; } 
    #else
    public OpeningClosing3Choice_? OpeningClosing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    [IsoId("__vsYQwyOEeuG8M5giQ2e0w")]
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
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("__vsYRwyOEeuG8M5giQ2e0w")]
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
    [IsoId("__vsYSwyOEeuG8M5giQ2e0w")]
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
    [IsoId("__vsYTwyOEeuG8M5giQ2e0w")]
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
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("__vsYUwyOEeuG8M5giQ2e0w")]
    [DisplayName("Type Of Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpOfPric")]
    #endif
    [IsoXmlTag("TpOfPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfPrice29Choice_? TypeOfPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice29Choice_? TypeOfPrice { get; init; } 
    #else
    public TypeOfPrice29Choice_? TypeOfPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds or to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    [IsoId("__vsYVwyOEeuG8M5giQ2e0w")]
    [DisplayName("Currency To Buy Or Sell")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyToBuyOrSell")]
    #endif
    [IsoXmlTag("CcyToBuyOrSell")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; } 
    #else
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("__vsYWwyOEeuG8M5giQ2e0w")]
    [DisplayName("Matching Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSts")]
    #endif
    [IsoXmlTag("MtchgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus27Choice_? MatchingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus27Choice_? MatchingStatus { get; init; } 
    #else
    public MatchingStatus27Choice_? MatchingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("__vsYXwyOEeuG8M5giQ2e0w")]
    [DisplayName("Affirmation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AffirmSts")]
    #endif
    [IsoXmlTag("AffirmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AffirmationStatus8Choice_? AffirmationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AffirmationStatus8Choice_? AffirmationStatus { get; init; } 
    #else
    public AffirmationStatus8Choice_? AffirmationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional details pertaining to foreign exchange instructions.
    /// </summary>
    [IsoId("__vsYYwyOEeuG8M5giQ2e0w")]
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
    
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("__vsYZwyOEeuG8M5giQ2e0w")]
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
    
    
    #nullable disable
    
}
