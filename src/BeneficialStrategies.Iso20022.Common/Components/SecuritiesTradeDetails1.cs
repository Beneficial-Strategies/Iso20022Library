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
[IsoId("_S8-sldp-Ed-ak6NoX_4Aeg_-1860738058")]
[DisplayName("Securities Trade Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesTradeDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesTradeDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesTradeDetails1( SettlementDate1Choice_ reqSettlementDate )
    {
        SettlementDate = reqSettlementDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    [IsoId("_S9IdgNp-Ed-ak6NoX_4Aeg_2076231064")]
    [DisplayName("Trade Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradId")]
    #endif
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradeIdentification { get; init; } 
    #else
    public System.String? TradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of a collateral transaction as assigned by the instructing party.
    /// </summary>
    [IsoId("_S9Idgdp-Ed-ak6NoX_4Aeg_309964435")]
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
    [IsoId("_S9Idgtp-Ed-ak6NoX_4Aeg_1066972832")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification4? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification4? PlaceOfTrade { get; init; } 
    #else
    public MarketIdentification4? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and wich facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [IsoId("_S9Idg9p-Ed-ak6NoX_4Aeg_2039077906")]
    [DisplayName("Place Of Clearing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfClr")]
    #endif
    [IsoXmlTag("PlcOfClr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? PlaceOfClearing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceOfClearing { get; init; } 
    #else
    public System.String? PlaceOfClearing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_S9IdhNp-Ed-ak6NoX_4Aeg_499309185")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeDate1Choice_? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDate1Choice_? TradeDate { get; init; } 
    #else
    public TradeDate1Choice_? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_S9Idhdp-Ed-ak6NoX_4Aeg_134519213")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDate1Choice_ SettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementDate1Choice_ SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDate1Choice_ SettlementDate { get; init; } 
    #else
    public SettlementDate1Choice_ SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    [IsoId("_S9Idhtp-Ed-ak6NoX_4Aeg_-158543881")]
    [DisplayName("Late Delivery Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LateDlvryDt")]
    #endif
    [IsoXmlTag("LateDlvryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? LateDeliveryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? LateDeliveryDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? LateDeliveryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    [IsoId("_S9Idh9p-Ed-ak6NoX_4Aeg_633219758")]
    [DisplayName("Deal Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealPric")]
    #endif
    [IsoXmlTag("DealPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price2? DealPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price2? DealPrice { get; init; } 
    #else
    public Price2? DealPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_S9IdiNp-Ed-ak6NoX_4Aeg_1983211210")]
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
    [IsoId("_S9RncNp-Ed-ak6NoX_4Aeg_617797467")]
    [DisplayName("Opening Closing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngClsg")]
    #endif
    [IsoXmlTag("OpngClsg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OpeningClosing1Choice_? OpeningClosing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OpeningClosing1Choice_? OpeningClosing { get; init; } 
    #else
    public OpeningClosing1Choice_? OpeningClosing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    [IsoId("_S9Rncdp-Ed-ak6NoX_4Aeg_-1056215682")]
    [DisplayName("Reporting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rptg")]
    #endif
    [IsoXmlTag("Rptg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reporting2Choice_? Reporting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reporting2Choice_? Reporting { get; init; } 
    #else
    public Reporting2Choice_? Reporting { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_S9Rnctp-Ed-ak6NoX_4Aeg_852626305")]
    [DisplayName("Trade Transaction Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradTxCond")]
    #endif
    [IsoXmlTag("TradTxCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeTransactionCondition1Choice_? TradeTransactionCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransactionCondition1Choice_? TradeTransactionCondition { get; init; } 
    #else
    public TradeTransactionCondition1Choice_? TradeTransactionCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the role of the investor in the transaction.
    /// </summary>
    [IsoId("_S9Rnc9p-Ed-ak6NoX_4Aeg_1454164888")]
    [DisplayName("Investor Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrCpcty")]
    #endif
    [IsoXmlTag("InvstrCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestorCapacity1Choice_? InvestorCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorCapacity1Choice_? InvestorCapacity { get; init; } 
    #else
    public InvestorCapacity1Choice_? InvestorCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    [IsoId("_S9RndNp-Ed-ak6NoX_4Aeg_1915927851")]
    [DisplayName("Trade Originator Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradOrgtrRole")]
    #endif
    [IsoXmlTag("TradOrgtrRole")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeOriginator1Choice_? TradeOriginatorRole { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeOriginator1Choice_? TradeOriginatorRole { get; init; } 
    #else
    public TradeOriginator1Choice_? TradeOriginatorRole { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_S9Rnddp-Ed-ak6NoX_4Aeg_-1530876311")]
    [DisplayName("Type Of Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpOfPric")]
    #endif
    [IsoXmlTag("TpOfPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfPrice3Choice_? TypeOfPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice3Choice_? TypeOfPrice { get; init; } 
    #else
    public TypeOfPrice3Choice_? TypeOfPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds or to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    [IsoId("_S9Rndtp-Ed-ak6NoX_4Aeg_816869195")]
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
    [IsoId("_S9Rnd9p-Ed-ak6NoX_4Aeg_1763154117")]
    [DisplayName("Matching Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSts")]
    #endif
    [IsoXmlTag("MtchgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus1Choice_? MatchingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus1Choice_? MatchingStatus { get; init; } 
    #else
    public MatchingStatus1Choice_? MatchingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("_S9bYcNp-Ed-ak6NoX_4Aeg_1781626184")]
    [DisplayName("Affirmation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AffirmSts")]
    #endif
    [IsoXmlTag("AffirmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AffirmationStatus1Choice_? AffirmationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AffirmationStatus1Choice_? AffirmationStatus { get; init; } 
    #else
    public AffirmationStatus1Choice_? AffirmationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional details pertaining to foreign exchange instructions.
    /// </summary>
    [IsoId("_S9bYcdp-Ed-ak6NoX_4Aeg_1183295694")]
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
    [IsoId("_S9bYctp-Ed-ak6NoX_4Aeg_764017269")]
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
