// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// This record is an implementation of the fxtr.038.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchangeTradeConfirmationStatusAdviceAcknowledgement message is sent from a market participant to a Central matching utility (CMU) in response to the FXTradeConfirmationStatusAdvice previously sent by the CMU in the scenario of trades matched by both participants.
/// 
/// Usage
/// The acknowledgement is sent by the trading member to the CMU after they received the confirmation status advice. 
/// Note that one confirmation status advice acknowledgement responds to one confirmation status advice.
/// </summary>
[Description(@"Scope|The ForeignExchangeTradeConfirmationStatusAdviceAcknowledgement message is sent from a market participant to a Central matching utility (CMU) in response to the FXTradeConfirmationStatusAdvice previously sent by the CMU in the scenario of trades matched by both participants.||Usage|The acknowledgement is sent by the trading member to the CMU after they received the confirmation status advice. |Note that one confirmation status advice acknowledgement responds to one confirmation status advice.")]
[IsoId("_4rvHkER_EeStEe_B2dcrqg")]
[DisplayName("Foreign Exchange Trade Confirmation Status Advice Acknowledgement V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchangeTradeConfirmationStatusAdviceAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.038.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradConfStsAdvcAck";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.038.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ForeignExchangeTradeConfirmationStatusAdviceAcknowledgementV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeTradeConfirmationStatusAdviceAcknowledgementV01( MessageIdentification1 reqRequestIdentification,System.DateOnly reqTradeDate,System.String reqTradeIdentification,TradingModeType1Code reqTradingMode,AffirmStatus1Code reqAffirmationStatus,TradeConfirmationStatus1Code reqConfirmationStatus,MarketIdentification88 reqMarketIdentification )
    {
        RequestIdentification = reqRequestIdentification;
        TradeDate = reqTradeDate;
        TradeIdentification = reqTradeIdentification;
        TradingMode = reqTradingMode;
        AffirmationStatus = reqAffirmationStatus;
        ConfirmationStatus = reqConfirmationStatus;
        MarketIdentification = reqMarketIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the advice acknowledgement.
    /// </summary>
    [IsoId("_BRy-cESAEeStEe_B2dcrqg")]
    [DisplayName("Advice Acknowledgement Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdvcAckId")]
    #endif
    [IsoXmlTag("AdvcAckId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageIdentification1? AdviceAcknowledgementIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1? AdviceAcknowledgementIdentification { get; init; } 
    #else
    public MessageIdentification1? AdviceAcknowledgementIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the request.
    /// </summary>
    [IsoId("__tUJkESjEeS6cOLECtYLrA")]
    [DisplayName("Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqId")]
    #endif
    [IsoXmlTag("ReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 RequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 RequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 RequestIdentification { get; init; } 
    #else
    public MessageIdentification1 RequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date on which the trade was executed.
    /// </summary>
    [IsoId("_TqsBUESAEeStEe_B2dcrqg")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate TradeDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly TradeDate { get; init; } 
    #else
    public System.DateOnly TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference identification assigned to the trade by the instructing party. This reference will be used throughout the trade life cycle to identify the particular trade.
    /// </summary>
    [IsoId("_qe6B0IsSEeS_1fMypAW06w")]
    [DisplayName("Trade Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradId")]
    #endif
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TradeIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradeIdentification { get; init; } 
    #else
    public System.String TradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of the trade mode.
    /// </summary>
    [IsoId("_wbqUIIsSEeS_1fMypAW06w")]
    [DisplayName("Trading Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgMd")]
    #endif
    [IsoXmlTag("TradgMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradingModeType1Code TradingMode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradingModeType1Code TradingMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingModeType1Code TradingMode { get; init; } 
    #else
    public TradingModeType1Code TradingMode { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the status of the confirmation acknowledgement.
    /// </summary>
    [IsoId("_viJsEESvEeSTS-T7FO4CUQ")]
    [DisplayName("Affirmation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AffirmSts")]
    #endif
    [IsoXmlTag("AffirmSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AffirmStatus1Code AffirmationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AffirmStatus1Code AffirmationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AffirmStatus1Code AffirmationStatus { get; init; } 
    #else
    public AffirmStatus1Code AffirmationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the status of the confirmation.
    /// </summary>
    [IsoId("_pYBHsIsREeS_1fMypAW06w")]
    [DisplayName("Confirmation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfSts")]
    #endif
    [IsoXmlTag("ConfSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeConfirmationStatus1Code ConfirmationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeConfirmationStatus1Code ConfirmationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeConfirmationStatus1Code ConfirmationStatus { get; init; } 
    #else
    public TradeConfirmationStatus1Code ConfirmationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [IsoId("_RD1T0ESAEeStEe_B2dcrqg")]
    [DisplayName("Market Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktId")]
    #endif
    [IsoXmlTag("MktId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarketIdentification88 MarketIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarketIdentification88 MarketIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification88 MarketIdentification { get; init; } 
    #else
    public MarketIdentification88 MarketIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Free format text string.
    /// </summary>
    [IsoId("_aiEI0ESAEeStEe_B2dcrqg")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation5? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation5? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation5? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1wlvYKHlEeS69KkQis5bYg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ForeignExchangeTradeConfirmationStatusAdviceAcknowledgementV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeConfirmationStatusAdviceAcknowledgementV01.

