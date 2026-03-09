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
/// Provides selected corporate action events message details extracted from the related custodian messages received.
/// </summary>
[IsoId("_1WNFoTL3EeKU9IrkkToqcw_735116614")]
[DisplayName("Related Custodian Message Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RelatedCustodianMessageDetailsSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RelatedCustodianMessageDetailsSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RelatedCustodianMessageDetailsSD1( System.String reqReceivedEventType,System.String reqReceivedMandatoryVoluntaryEventType,System.String reqReceivedCorporateActionEventIdentification,System.DateOnly reqReceivedDate,System.String reqInboundISOMessageType,System.String reqInboundISOMessageReceiverBIC,System.String reqReceivedRelatedReference,System.String reqReceivedSenderMessageReference,System.String reqInboundISOMessageSenderBIC )
    {
        ReceivedEventType = reqReceivedEventType;
        ReceivedMandatoryVoluntaryEventType = reqReceivedMandatoryVoluntaryEventType;
        ReceivedCorporateActionEventIdentification = reqReceivedCorporateActionEventIdentification;
        ReceivedDate = reqReceivedDate;
        InboundISOMessageType = reqInboundISOMessageType;
        InboundISOMessageReceiverBIC = reqInboundISOMessageReceiverBIC;
        ReceivedRelatedReference = reqReceivedRelatedReference;
        ReceivedSenderMessageReference = reqReceivedSenderMessageReference;
        InboundISOMessageSenderBIC = reqInboundISOMessageSenderBIC;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference the CAEV value from the received custodian message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WNFojL3EeKU9IrkkToqcw_1873449067")]
    [DisplayName("Received Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvdEvtTp")]
    #endif
    [IsoXmlTag("RcvdEvtTp")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4AlphaNumericText ReceivedEventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReceivedEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReceivedEventType { get; init; } 
    #else
    public System.String ReceivedEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Reference the CAMV value from the received custodian message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WNFozL3EeKU9IrkkToqcw_-948266421")]
    [DisplayName("Received Mandatory Voluntary Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvdMndtryVlntryEvtTp")]
    #endif
    [IsoXmlTag("RcvdMndtryVlntryEvtTp")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4AlphaNumericText ReceivedMandatoryVoluntaryEventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReceivedMandatoryVoluntaryEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReceivedMandatoryVoluntaryEventType { get; init; } 
    #else
    public System.String ReceivedMandatoryVoluntaryEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Reference the CORP value from the received custodian message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WNFpDL3EeKU9IrkkToqcw_1342648125")]
    [DisplayName("Received Corporate Action Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvdCorpActnEvtId")]
    #endif
    [IsoXmlTag("RcvdCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax16Text ReceivedCorporateActionEventIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReceivedCorporateActionEventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReceivedCorporateActionEventIdentification { get; init; } 
    #else
    public System.String ReceivedCorporateActionEventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Rate that the ISO message was received from the custodian. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WNFpTL3EeKU9IrkkToqcw_1703993481")]
    [DisplayName("Received Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvdDt")]
    #endif
    [IsoXmlTag("RcvdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ReceivedDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ReceivedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ReceivedDate { get; init; } 
    #else
    public System.DateOnly ReceivedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Time of day that the ISO message was received from the custodian. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WWPkDL3EeKU9IrkkToqcw_-1439843261")]
    [DisplayName("Received Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvdTm")]
    #endif
    [IsoXmlTag("RcvdTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? ReceivedTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? ReceivedTime { get; init; } 
    #else
    public System.TimeOnly? ReceivedTime { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the ISO15022 MT message type received from the custodian message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WWPkTL3EeKU9IrkkToqcw_519445599")]
    [DisplayName("Inbound ISO Message Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InbndISOMT")]
    #endif
    [IsoXmlTag("InbndISOMT")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact3NumericText InboundISOMessageType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InboundISOMessageType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InboundISOMessageType { get; init; } 
    #else
    public System.String InboundISOMessageType { get; set; } 
    #endif
    
    /// <summary>
    /// BIC Code of the recipient of the custodian record on a received message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WWPkjL3EeKU9IrkkToqcw_1590634510")]
    [DisplayName("Inbound ISO Message Receiver BIC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InbndISOMsgRcvrBIC")]
    #endif
    [IsoXmlTag("InbndISOMsgRcvrBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier InboundISOMessageReceiverBIC { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InboundISOMessageReceiverBIC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InboundISOMessageReceiverBIC { get; init; } 
    #else
    public System.String InboundISOMessageReceiverBIC { get; set; } 
    #endif
    
    /// <summary>
    /// Sender related reference from the received custodian message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WWPkzL3EeKU9IrkkToqcw_-2146269993")]
    [DisplayName("Received Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvdRltdRef")]
    #endif
    [IsoXmlTag("RcvdRltdRef")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax16Text ReceivedRelatedReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReceivedRelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReceivedRelatedReference { get; init; } 
    #else
    public System.String ReceivedRelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Sender SEME from received custodian message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WWPlDL3EeKU9IrkkToqcw_-1013529054")]
    [DisplayName("Received Sender Message Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvdSndrMsgRef")]
    #endif
    [IsoXmlTag("RcvdSndrMsgRef")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax16Text ReceivedSenderMessageReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReceivedSenderMessageReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReceivedSenderMessageReference { get; init; } 
    #else
    public System.String ReceivedSenderMessageReference { get; set; } 
    #endif
    
    /// <summary>
    /// BIC Code of the sender of the custodian record on a received message. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1WWPlTL3EeKU9IrkkToqcw_1794390087")]
    [DisplayName("Inbound ISO Message Sender BIC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InbndISOMsgSndrBIC")]
    #endif
    [IsoXmlTag("InbndISOMsgSndrBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier InboundISOMessageSenderBIC { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InboundISOMessageSenderBIC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InboundISOMessageSenderBIC { get; init; } 
    #else
    public System.String InboundISOMessageSenderBIC { get; set; } 
    #endif
    
    
    #nullable disable
    
}
