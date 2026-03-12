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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.063.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The PayInEventAcknowledgement message is sent by a participant of a central system to the central system to confirm a PayInSchedule or a PayInCall has been received.
/// 
/// </summary>
[Description(@"The PayInEventAcknowledgement message is sent by a participant of a central system to the central system to confirm a PayInSchedule or a PayInCall has been received.|")]
[IsoId("_eii_URnXEeKKXqHkeUjBbw")]
[DisplayName("Pay In Event Acknowledgement V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PayInEventAcknowledgementV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.063.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PayInEvtAck";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.063.001.02";
    
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
    /// Constructs a PayInEventAcknowledgementV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PayInEventAcknowledgementV02( System.String reqMessageIdentification,AcknowledgementDetails1Choice_ reqAcknowledgementDetails )
    {
        MessageIdentification = reqMessageIdentification;
        AcknowledgementDetails = reqAcknowledgementDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the message, as assigned by the sender.
    /// </summary>
    [IsoId("_1VTQczp7EeKXK8qRvydwAw")]
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
    /// To indicate the requested CLS Settlement Session that the related trade is part of.
    /// </summary>
    [IsoId("_SY6S7R3bEeKXIbeXfdPzuw")]
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
    /// Details of the pay in schedule or pay in call being acknowledged.
    /// </summary>
    [IsoId("_eii_VxnXEeKKXqHkeUjBbw")]
    [DisplayName("Acknowledgement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AckDtls")]
    #endif
    [IsoXmlTag("AckDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcknowledgementDetails1Choice_ AcknowledgementDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcknowledgementDetails1Choice_ AcknowledgementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcknowledgementDetails1Choice_ AcknowledgementDetails { get; init; } 
    #else
    public AcknowledgementDetails1Choice_ AcknowledgementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Cu8KTy53EeKwTrPDLMbLxA")]
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


// Since PayInEventAcknowledgementV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PayInEventAcknowledgementV02.

