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
/// Information to display, print or store.
/// </summary>
[IsoId("_xQalMXuYEeSVeNXcmBQ4hQ")]
[DisplayName("Action Message")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ActionMessage2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ActionMessage2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ActionMessage2( UserInterface4Code reqMessageDestination,System.String reqMessageContent )
    {
        MessageDestination = reqMessageDestination;
        MessageContent = reqMessageContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Destination of the message.
    /// </summary>
    [IsoId("_xdYDIXuYEeSVeNXcmBQ4hQ")]
    [DisplayName("Message Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgDstn")]
    #endif
    [IsoXmlTag("MsgDstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UserInterface4Code MessageDestination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UserInterface4Code MessageDestination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UserInterface4Code MessageDestination { get; init; } 
    #else
    public UserInterface4Code MessageDestination { get; set; } 
    #endif
    
    /// <summary>
    /// Message format.
    /// </summary>
    [IsoId("_IC3pUHuZEeSVeNXcmBQ4hQ")]
    [DisplayName("Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frmt")]
    #endif
    [IsoXmlTag("Frmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OutputFormat1Code? Format { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OutputFormat1Code? Format { get; init; } 
    #else
    public OutputFormat1Code? Format { get; set; } 
    #endif
    
    /// <summary>
    /// Content or reference of the message.
    /// </summary>
    [IsoId("_xdYDI3uYEeSVeNXcmBQ4hQ")]
    [DisplayName("Message Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgCntt")]
    #endif
    [IsoXmlTag("MsgCntt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20000Text MessageContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageContent { get; init; } 
    #else
    public System.String MessageContent { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the message.
    /// </summary>
    [IsoId("_xdYDJXuYEeSVeNXcmBQ4hQ")]
    [DisplayName("Message Content Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgCnttSgntr")]
    #endif
    [IsoXmlTag("MsgCnttSgntr")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? MessageContentSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? MessageContentSignature { get; init; } 
    #else
    public System.Byte[]? MessageContentSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}
