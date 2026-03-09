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
/// Identification of a message previously sent.
/// </summary>
[IsoId("_-Cue8nltEeG7BsjMvd1mEw_1352240882")]
[DisplayName("Original Message")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalMessage1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalMessage1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalMessage1( System.String reqMessageDefinitionIdentifier,Party9Choice_ reqFrom,Party9Choice_ reqTo,System.String reqBusinessMessageIdentifier,System.DateTime reqCreationDate )
    {
        MessageDefinitionIdentifier = reqMessageDefinitionIdentifier;
        From = reqFrom;
        To = reqTo;
        BusinessMessageIdentifier = reqBusinessMessageIdentifier;
        CreationDate = reqCreationDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// XML schema-instance namespace, for example &quot;tsin.008.001.01&quot;.
    /// </summary>
    [IsoId("_-Cue83ltEeG7BsjMvd1mEw_-699317533")]
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
    /// Message sender specified in the original message.|
    /// </summary>
    [IsoId("_-Cue9HltEeG7BsjMvd1mEw_-135925947")]
    [DisplayName("From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fr")]
    #endif
    [IsoXmlTag("Fr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party9Choice_ From { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party9Choice_ From { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party9Choice_ From { get; init; } 
    #else
    public Party9Choice_ From { get; set; } 
    #endif
    
    /// <summary>
    /// Message recipient specified in the original message.
    /// </summary>
    [IsoId("_-Cue9XltEeG7BsjMvd1mEw_-844084979")]
    [DisplayName("To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="To")]
    #endif
    [IsoXmlTag("To")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party9Choice_ To { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party9Choice_ To { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party9Choice_ To { get; init; } 
    #else
    public Party9Choice_ To { get; set; } 
    #endif
    
    /// <summary>
    /// Message identification specified in the original message.
    /// </summary>
    [IsoId("_-Cue9nltEeG7BsjMvd1mEw_-2054731857")]
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
    /// Message creation date and time specified in the original message.
    /// </summary>
    [IsoId("_-C4P8HltEeG7BsjMvd1mEw_1720315394")]
    [DisplayName("Creation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDt")]
    #endif
    [IsoXmlTag("CreDt")]
    [IsoSimpleType(IsoSimpleType.ISONormalisedDateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISONormalisedDateTime CreationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDate { get; init; } 
    #else
    public System.DateTime CreationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the message is a copy, a duplicate or a copy of a duplicate of a previously sent ISO 20022 message.
    /// </summary>
    [IsoId("_-C4P8XltEeG7BsjMvd1mEw_-1157358019")]
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
    
    
    #nullable disable
    
}
