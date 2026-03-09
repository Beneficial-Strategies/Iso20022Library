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
/// Specifies specific data from the Business Application Header of the Business Message.
/// </summary>
[IsoId("_O1C_XEvwEeWw591U1lOHyQ")]
[DisplayName("Business Application Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BusinessApplicationHeader3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BusinessApplicationHeader3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BusinessApplicationHeader3( Party29Choice_ reqFrom,Party29Choice_ reqTo,System.String reqBusinessMessageIdentifier,System.String reqMessageDefinitionIdentifier,System.DateTime reqCreationDate )
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
    /// The sending MessagingEndpoint that has created this Business Message for the receiving MessagingEndpoint that will process this Business Message.
    /// Note	the sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_O1C_Z0vwEeWw591U1lOHyQ")]
    [DisplayName("From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fr")]
    #endif
    [IsoXmlTag("Fr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party29Choice_ From { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party29Choice_ From { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party29Choice_ From { get; init; } 
    #else
    public Party29Choice_ From { get; set; } 
    #endif
    
    /// <summary>
    /// The MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this Business Message.
    /// Note the receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_O1C_X0vwEeWw591U1lOHyQ")]
    [DisplayName("To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="To")]
    #endif
    [IsoXmlTag("To")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party29Choice_ To { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party29Choice_ To { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party29Choice_ To { get; init; } 
    #else
    public Party29Choice_ To { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguously identifies the Business Message to the MessagingEndpoint that has created the Business Message.
    /// </summary>
    [IsoId("_O1C_YUvwEeWw591U1lOHyQ")]
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
    [IsoId("_O1C_ZkvwEeWw591U1lOHyQ")]
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
    [IsoId("_O1C_ZUvwEeWw591U1lOHyQ")]
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
    [IsoId("_O1C_ZEvwEeWw591U1lOHyQ")]
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
    
    
    #nullable disable
    
}
