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


namespace BeneficialStrategies.Iso20022.head;

/// <summary>
/// This record is an implementation of the head.001.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Business Layer deals with Business Messages. The behaviour of the Business Messages is fully described by the Business Transaction and the structure of the Business Messages is fully described by the Message Definitions and related Message Rules, Rules and Market Practices. All of which are registered in the ISO 20022 Repository.
/// A single new Business Message (with its accompagnying business application header) is created - by the sending MessagingEndpoint - for each business event; that is each interaction in a Business Transaction. A Business Message adheres to the following principles:
/// &quot; A Business Message (and its business application header) must not contain information about the Message Transport System or the mechanics or mechanism of message sending, transportation, or receipt. 
/// &quot; A Business Message must be comprehensible outside of the context of the Transport Message. That is the Business Message must not require knowledge of the Transport Message to be understood.
/// &quot; A Business Message may contain headers, footers, and envelopes that are meaningful for the business. When present, they are treated as any other message content, which means that they are considered part of the Message Definition of the Business Message and as such will be part of the ISO 20022 Repository.
/// &quot; A Business Message refers to Business Actors by their Name. Each instance of a Business Actor has one Name. The Business Actor must not be referred to in the Transport Layer.
/// Specific usage of this BusinessMessageHeader may be defined by the relevant SEG.
/// </summary>
[Description(@"The Business Layer deals with Business Messages. The behaviour of the Business Messages is fully described by the Business Transaction and the structure of the Business Messages is fully described by the Message Definitions and related Message Rules, Rules and Market Practices. All of which are registered in the ISO 20022 Repository.|A single new Business Message (with its accompagnying business application header) is created - by the sending MessagingEndpoint - for each business event; that is each interaction in a Business Transaction. A Business Message adheres to the following principles:|"" A Business Message (and its business application header) must not contain information about the Message Transport System or the mechanics or mechanism of message sending, transportation, or receipt. |"" A Business Message must be comprehensible outside of the context of the Transport Message. That is the Business Message must not require knowledge of the Transport Message to be understood.|"" A Business Message may contain headers, footers, and envelopes that are meaningful for the business. When present, they are treated as any other message content, which means that they are considered part of the Message Definition of the Business Message and as such will be part of the ISO 20022 Repository.|"" A Business Message refers to Business Actors by their Name. Each instance of a Business Actor has one Name. The Business Actor must not be referred to in the Transport Layer.|Specific usage of this BusinessMessageHeader may be defined by the relevant SEG.")]
[IsoId("_6wX5Uch7Eei73Ywzx0CAAg")]
[DisplayName("Business Application Header V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BusinessApplicationHeaderV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "head.001.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AppHdr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.02";
    
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
    /// Constructs a BusinessApplicationHeaderV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BusinessApplicationHeaderV02( Party44Choice_ reqFrom,Party44Choice_ reqTo,System.String reqBusinessMessageIdentifier,System.String reqMessageDefinitionIdentifier,System.DateTime reqCreationDate )
    {
        From = reqFrom;
        To = reqTo;
        BusinessMessageIdentifier = reqBusinessMessageIdentifier;
        MessageDefinitionIdentifier = reqMessageDefinitionIdentifier;
        CreationDate = reqCreationDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the character set of the text-based elements used in the Business Message.
    /// </summary>
    [IsoId("_6wX5Vch7Eei73Ywzx0CAAg")]
    [DisplayName("Character Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CharSet")]
    #endif
    [IsoXmlTag("CharSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnicodeChartsCode? CharacterSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CharacterSet { get; init; } 
    #else
    public string? CharacterSet { get; set; } 
    #endif
    
    /// <summary>
    /// The sending MessagingEndpoint that has created this Business Message for the receiving MessagingEndpoint that will process this Business Message.
    /// Note	the sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_6wX5V8h7Eei73Ywzx0CAAg")]
    [DisplayName("From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fr")]
    #endif
    [IsoXmlTag("Fr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party44Choice_ From { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party44Choice_ From { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party44Choice_ From { get; init; } 
    #else
    public Party44Choice_ From { get; set; } 
    #endif
    
    /// <summary>
    /// The MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this Business Message.
    /// Note the receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_6wX5Wch7Eei73Ywzx0CAAg")]
    [DisplayName("To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="To")]
    #endif
    [IsoXmlTag("To")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party44Choice_ To { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party44Choice_ To { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party44Choice_ To { get; init; } 
    #else
    public Party44Choice_ To { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguously identifies the Business Message to the MessagingEndpoint that has created the Business Message.
    /// </summary>
    [IsoId("_6wX5W8h7Eei73Ywzx0CAAg")]
    [DisplayName("Business Message Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizMsgIdr")]
    #endif
    [IsoXmlTag("BizMsgIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text BusinessMessageIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BusinessMessageIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BusinessMessageIdentifier { get; init; } 
    #else
    public System.String BusinessMessageIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the MessageIdentifier that defines the BusinessMessage.
    /// It must contain a MessageIdentifier published on the ISO 20022 website.
    /// example	camt.001.001.03.
    /// </summary>
    [IsoId("_6wX5Xch7Eei73Ywzx0CAAg")]
    [DisplayName("Message Definition Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgDefIdr")]
    #endif
    [IsoXmlTag("MsgDefIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageDefinitionIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageDefinitionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageDefinitionIdentifier { get; init; } 
    #else
    public System.String MessageDefinitionIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the business service agreed between the two MessagingEndpoints under which rules this Business Message is exchanged.
    ///  To be used when there is a choice of processing services or processing service levels.
    /// Example: E&amp;I.
    /// </summary>
    [IsoId("_6wX5X8h7Eei73Ywzx0CAAg")]
    [DisplayName("Business Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizSvc")]
    #endif
    [IsoXmlTag("BizSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BusinessService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BusinessService { get; init; } 
    #else
    public System.String? BusinessService { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the market practice to which the message conforms. The market practices are a set of rules agreed between parties that restricts the usage of the messages in order to achieve better STP (Straight Through Processing) rates.
    /// A market practice specification may also extend the underlying message specification by using extensions or supplementary data of this underlying message.
    /// </summary>
    [IsoId("_v5qgkMieEei73Ywzx0CAAg")]
    [DisplayName("Market Practice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktPrctc")]
    #endif
    [IsoXmlTag("MktPrctc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImplementationSpecification1? MarketPractice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImplementationSpecification1? MarketPractice { get; init; } 
    #else
    public ImplementationSpecification1? MarketPractice { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time when this Business Message (header) was created.
    /// </summary>
    [IsoId("_6wX5Ych7Eei73Ywzx0CAAg")]
    [DisplayName("Creation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDt")]
    #endif
    [IsoXmlTag("CreDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDate { get; init; } 
    #else
    public System.DateTime CreationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Processing date and time indicated by the sender for the receiver of the business message. This date may be different from the date and time provided in the CreationDate.
    /// Usage: Market practice or bilateral agreement should specify how this element should be used.
    /// </summary>
    [IsoId("_A2wWAMiuEei73Ywzx0CAAg")]
    [DisplayName("Business Processing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizPrcgDt")]
    #endif
    [IsoXmlTag("BizPrcgDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? BusinessProcessingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? BusinessProcessingDate { get; init; } 
    #else
    public System.DateTime? BusinessProcessingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the message is a Copy, a Duplicate or a copy of a duplicate of a previously sent ISO 20022 Message.
    /// </summary>
    [IsoId("_6wX5Y8h7Eei73Ywzx0CAAg")]
    [DisplayName("Copy Duplicate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpyDplct")]
    #endif
    [IsoXmlTag("CpyDplct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CopyDuplicate1Code? CopyDuplicate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CopyDuplicate1Code? CopyDuplicate { get; init; } 
    #else
    public CopyDuplicate1Code? CopyDuplicate { get; set; } 
    #endif
    
    /// <summary>
    /// Flag indicating if the Business Message exchanged between the MessagingEndpoints is possibly a duplicate. 
    /// If the receiving MessagingEndpoint did not receive the original, then this Business Message should be processed as if it were the original. 
    /// If the receiving MessagingEndpoint did receive the original, then it should perform necessary actions to avoid processing this Business Message again.
    /// This will guarantee business idempotent behaviour.
    /// NOTE: this is named &quot;PossResend&quot; in FIX - this is an application level resend not a network level retransmission.
    /// </summary>
    [IsoId("_6wX5Zch7Eei73Ywzx0CAAg")]
    [DisplayName("Possible Duplicate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PssblDplct")]
    #endif
    [IsoXmlTag("PssblDplct")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PossibleDuplicate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PossibleDuplicate { get; init; } 
    #else
    public System.String? PossibleDuplicate { get; set; } 
    #endif
    
    /// <summary>
    /// Relative indication of the processing precedence of the message over a (set of) Business Messages with assigned priorities.
    /// </summary>
    [IsoId("_6wX5Z8h7Eei73Ywzx0CAAg")]
    [DisplayName("Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prty")]
    #endif
    [IsoXmlTag("Prty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BusinessMessagePriorityCode? Priority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Priority { get; init; } 
    #else
    public string? Priority { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the digital signature of the Business Entity authorised to sign this Business Message.
    /// </summary>
    [IsoId("_6wX5ach7Eei73Ywzx0CAAg")]
    [DisplayName("Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgntr")]
    #endif
    [IsoXmlTag("Sgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignatureEnvelope? Signature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignatureEnvelope? Signature { get; init; } 
    #else
    public SignatureEnvelope? Signature { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the Business Application Header(s) of the Business Message(s) to which this Business Message relates.
    /// Can be used when replying to a query; can also be used when canceling or amending.
    /// </summary>
    [IsoId("_6wX5a8h7Eei73Ywzx0CAAg")]
    [DisplayName("Related")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rltd")]
    #endif
    [IsoXmlTag("Rltd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BusinessApplicationHeader5? Related { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessApplicationHeader5? Related { get; init; } 
    #else
    public BusinessApplicationHeader5? Related { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since BusinessApplicationHeaderV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BusinessApplicationHeaderV02.

