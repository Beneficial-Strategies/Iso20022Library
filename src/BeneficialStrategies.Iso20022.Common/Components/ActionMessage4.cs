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
/// Information to display, print or log.
/// </summary>
[IsoId("_Nf6MEYqHEeSRT5rEzcAHEw")]
[DisplayName("Action Message")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ActionMessage4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information format.
    /// </summary>
    [IsoId("_Nsa-E4qHEeSRT5rEzcAHEw")]
    [DisplayName("Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frmt")]
    #endif
    [IsoXmlTag("Frmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OutputFormat2Code? Format { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OutputFormat2Code? Format { get; init; } 
    #else
    public OutputFormat2Code? Format { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the message.
    /// </summary>
    [IsoId("_Nsa-FYqHEeSRT5rEzcAHEw")]
    [DisplayName("Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Msg")]
    #endif
    [IsoXmlTag("Msg")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20000Text? Message { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Message { get; init; } 
    #else
    public System.String? Message { get; set; } 
    #endif
    
    /// <summary>
    /// Message content if this is a message reference or screen reference.
    /// </summary>
    [IsoId("_zAVggIqHEeSRT5rEzcAHEw")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reference { get; init; } 
    #else
    public System.String? Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Device to be used.
    /// </summary>
    [IsoId("_cCmkAIqIEeSRT5rEzcAHEw")]
    [DisplayName("Device")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dvc")]
    #endif
    [IsoXmlTag("Dvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMDevice1Code? Device { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMDevice1Code? Device { get; init; } 
    #else
    public ATMDevice1Code? Device { get; set; } 
    #endif
    
    /// <summary>
    /// Electronic signature of the message to display or print.
    /// </summary>
    [IsoId("_ki80cIqIEeSRT5rEzcAHEw")]
    [DisplayName("Message Content Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgCnttSgntr")]
    #endif
    [IsoXmlTag("MsgCnttSgntr")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Binary? MessageContentSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? MessageContentSignature { get; init; } 
    #else
    public System.Byte[]? MessageContentSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}
