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
/// Message to be displayed to the cardholder or the cashier.
/// </summary>
[IsoId("_t9yQoY0lEeWzoK7sd7oTyw")]
[DisplayName("Action Message")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ActionMessage5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ActionMessage5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ActionMessage5( System.String reqMessageContent )
    {
        MessageContent = reqMessageContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Format of the content.
    /// </summary>
    [IsoId("_Ic0UMI0mEeWzoK7sd7oTyw")]
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
    /// Text or graphic data to be display or printed to the cardholder or the cashier.
    /// </summary>
    [IsoId("_uJtMw40lEeWzoK7sd7oTyw")]
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
    
    
    #nullable disable
    
}
