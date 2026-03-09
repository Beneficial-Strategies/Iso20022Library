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
[IsoId("_NoHuwVN5EeOEi5J12GuNGQ")]
[DisplayName("Trade Agreement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeAgreement11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeAgreement11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeAgreement11( System.DateOnly reqTradeDate,System.String reqOriginatorReference,MatchingSystemReference1Choice_ reqMatchingSystemReference )
    {
        TradeDate = reqTradeDate;
        OriginatorReference = reqOriginatorReference;
        MatchingSystemReference = reqMatchingSystemReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which the trading parties agreed to amend or cancel the trade.
    /// </summary>
    [IsoId("_N7Mbw1N5EeOEi5J12GuNGQ")]
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
    /// Reference of the present instruction assigned by the party issuing the message. This reference must be unique amongst all messages of same type sent by the same party.
    /// </summary>
    [IsoId("_N7MbxVN5EeOEi5J12GuNGQ")]
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
    /// Identification of a matching system reference by a choice between a matching system unique identification or the related reference.
    /// </summary>
    [IsoId("_N7Mbx1N5EeOEi5J12GuNGQ")]
    [DisplayName("Matching System Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSysRef")]
    #endif
    [IsoXmlTag("MtchgSysRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MatchingSystemReference1Choice_ MatchingSystemReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MatchingSystemReference1Choice_ MatchingSystemReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingSystemReference1Choice_ MatchingSystemReference { get; init; } 
    #else
    public MatchingSystemReference1Choice_ MatchingSystemReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference common to both parties of the trade.
    /// </summary>
    [IsoId("_N7MbyVN5EeOEi5J12GuNGQ")]
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
    /// Describes the reason for the cancellation or the amendment.
    /// </summary>
    [IsoId("_N7Mby1N5EeOEi5J12GuNGQ")]
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
    /// Specifies the type of underlying transaction, for example cancellation (CANC).
    /// </summary>
    [IsoId("_N7MbzVN5EeOEi5J12GuNGQ")]
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
    /// Specifies the business role between the submitter and the trade party, for example Agent (AGNT).
    /// </summary>
    [IsoId("_N7Mbz1N5EeOEi5J12GuNGQ")]
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
    /// To indicate the requested CLS settlement session that the related trade is part of.
    /// </summary>
    [IsoId("_N7Mb0VN5EeOEi5J12GuNGQ")]
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
    /// Specifies if the FX transaction is PVP settlement. Payment versus payment (PvP) settlement arrangement allows for two currencies in a foreign exchange (FX) contract to exchange simultaneously on a central settlement platform to eliminate the settlement risk. To apply PvP, the two parties in the FX contract need to have a pre-agreement with the central settlement platform, for example, USD/MYR FX deals require both parties to have an agreement to settle via HK Interbank Clearing Ltd settlement platform.
    /// </summary>
    [IsoId("_QMoS4VN5EeOEi5J12GuNGQ")]
    [DisplayName("Payment Versus Payment Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtVrssPmtInd")]
    #endif
    [IsoXmlTag("PmtVrssPmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PaymentVersusPaymentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentVersusPaymentIndicator { get; init; } 
    #else
    public System.String? PaymentVersusPaymentIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
