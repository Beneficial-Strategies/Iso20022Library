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
/// Date and identification of a trade together with references to previous events in its life.
/// </summary>
[IsoId("_U6W0USNfEeKkK9gFRqAdSA")]
[DisplayName("Trade Agreement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeAgreement9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeAgreement9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeAgreement9( System.DateOnly reqTradeDate,System.String reqMessageIdentification,System.String reqOriginatorReference,System.String reqSplitTradeIndicator )
    {
        TradeDate = reqTradeDate;
        MessageIdentification = reqMessageIdentification;
        OriginatorReference = reqOriginatorReference;
        SplitTradeIndicator = reqSplitTradeIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which the trading parties agreed on the trade.
    /// </summary>
    [IsoId("_VGS-nCNfEeKkK9gFRqAdSA")]
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
    /// Identification of the present message assigned by the party issuing the message. This identification must be unique amongst all messages of same type sent by the same party.
    /// </summary>
    [IsoId("_7ldMoDqLEeKXK8qRvydwAw")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageIdentification { get; init; } 
    #else
    public System.String MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Represents the original reference of the instruction for which the status is given, as assigned by the participant that submitted the foreign exchange trade.
    /// </summary>
    [IsoId("_VGS-oyNfEeKkK9gFRqAdSA")]
    [DisplayName("Originator Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgtrRef")]
    #endif
    [IsoXmlTag("OrgtrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginatorReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginatorReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginatorReference { get; init; } 
    #else
    public System.String OriginatorReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference common to both parties of the trade.
    /// </summary>
    [IsoId("_VGTlpSNfEeKkK9gFRqAdSA")]
    [DisplayName("Common Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonRef")]
    #endif
    [IsoXmlTag("CmonRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CommonReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommonReference { get; init; } 
    #else
    public System.String? CommonReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for the cancellation or the amendment.
    /// </summary>
    [IsoId("_VGTlrCNfEeKkK9gFRqAdSA")]
    [DisplayName("Amend Or Cancel Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdOrCclRsn")]
    #endif
    [IsoXmlTag("AmdOrCclRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AmendOrCancelReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AmendOrCancelReason { get; init; } 
    #else
    public System.String? AmendOrCancelReason { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the identification of a previous event in the life of a trade which is amended or cancelled.
    /// </summary>
    [IsoId("_VGTlsyNfEeKkK9gFRqAdSA")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RelatedReference { get; init; } 
    #else
    public System.String? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the product for which the status of the confirmation is reported.
    /// </summary>
    [IsoId("_mfUsBTm9EeKBIOJJJzlg2Q")]
    [DisplayName("Product Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctTp")]
    #endif
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductType { get; init; } 
    #else
    public System.String? ProductType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of underlying transaction, for example cancellation (CANC).
    /// </summary>
    [IsoId("_VGTluiNfEeKkK9gFRqAdSA")]
    [DisplayName("Operation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OprTp")]
    #endif
    [IsoXmlTag("OprTp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? OperationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OperationType { get; init; } 
    #else
    public System.String? OperationType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the business role between the submitter and the trade party, for example, agent (AGNT).
    /// </summary>
    [IsoId("_VGTlwSNfEeKkK9gFRqAdSA")]
    [DisplayName("Operation Scope")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OprScp")]
    #endif
    [IsoXmlTag("OprScp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? OperationScope { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OperationScope { get; init; } 
    #else
    public System.String? OperationScope { get; set; } 
    #endif
    
    /// <summary>
    /// To indicate the requested CLS Settlement Session that the related trade is part of.
    /// </summary>
    [IsoId("_VGTlyCNfEeKkK9gFRqAdSA")]
    [DisplayName("Settlement Session Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSsnIdr")]
    #endif
    [IsoXmlTag("SttlmSsnIdr")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SettlementSessionIdentifier { get; init; } 
    #else
    public System.String? SettlementSessionIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// To indicate if the trade is split.
    /// </summary>
    [IsoId("_h1IosCNfEeKkK9gFRqAdSA")]
    [DisplayName("Split Trade Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpltTradInd")]
    #endif
    [IsoXmlTag("SpltTradInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator SplitTradeIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SplitTradeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SplitTradeIndicator { get; init; } 
    #else
    public System.String SplitTradeIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
