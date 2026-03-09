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
/// Specifies the Business Application Header of the Business Message.
/// Can be used when replying to a query; can also be used when canceling or amending.
/// </summary>
[IsoId("_NorCwciBEei73Ywzx0CAAg")]
[DisplayName("Business Application Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BusinessApplicationHeader5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BusinessApplicationHeader5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BusinessApplicationHeader5( Party44Choice_ reqFrom,Party44Choice_ reqTo,System.String reqBusinessMessageIdentifier,System.String reqMessageDefinitionIdentifier,System.DateTime reqCreationDate )
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
    [IsoId("_N0t6sciBEei73Ywzx0CAAg")]
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
    [IsoId("_N0t6s8iBEei73Ywzx0CAAg")]
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
    [IsoId("_N0t6tciBEei73Ywzx0CAAg")]
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
    [IsoId("_N0t6t8iBEei73Ywzx0CAAg")]
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
    [IsoId("_N0t6uciBEei73Ywzx0CAAg")]
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
    [IsoId("_N0t6u8iBEei73Ywzx0CAAg")]
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
    /// Date and time when this Business Message (header) was created.
    /// Note Times must be normalized, using the &quot;Z&quot; annotation.
    /// </summary>
    [IsoId("_N0t6vciBEei73Ywzx0CAAg")]
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
    /// Indicates whether the message is a Copy, a Duplicate or a copy of a duplicate of a previously sent ISO 20022 Message.
    /// </summary>
    [IsoId("_N0t6v8iBEei73Ywzx0CAAg")]
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
    [IsoId("_N0t6wciBEei73Ywzx0CAAg")]
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
    [IsoId("_N0t6w8iBEei73Ywzx0CAAg")]
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
    [IsoId("_N0t6xciBEei73Ywzx0CAAg")]
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
    
    
    #nullable disable
    
}
