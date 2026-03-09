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
/// Additional information relevant to the destination.
/// </summary>
[IsoId("_n7eS8EXYEeegp_DADCe7HQ")]
[DisplayName("Additional Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalInformation20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AdditionalInformation20 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AdditionalInformation20( System.String reqValue )
    {
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Recipient of the additional information to display, print, send or store.
    /// </summary>
    [IsoId("_728i4EXYEeegp_DADCe7HQ")]
    [DisplayName("Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcpt")]
    #endif
    [IsoXmlTag("Rcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyType22Code? Recipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType22Code? Recipient { get; init; } 
    #else
    public PartyType22Code? Recipient { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of recipient of action data.
    /// </summary>
    [IsoId("_2IAAoFKdEeeFcfYfFkVztg")]
    [DisplayName("Other Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRcpt")]
    #endif
    [IsoXmlTag("OthrRcpt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherRecipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherRecipient { get; init; } 
    #else
    public System.String? OtherRecipient { get; set; } 
    #endif
    
    /// <summary>
    /// Target of the additional information to print, display, send or store.
    /// </summary>
    [IsoId("_CbEXMEXZEeegp_DADCe7HQ")]
    [DisplayName("Target")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trgt")]
    #endif
    [IsoXmlTag("Trgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UserInterface6Code? Target { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UserInterface6Code? Target { get; init; } 
    #else
    public UserInterface6Code? Target { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of target for action data.
    /// </summary>
    [IsoId("_8Jnk0FKdEeeFcfYfFkVztg")]
    [DisplayName("Other Target")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTrgt")]
    #endif
    [IsoXmlTag("OthrTrgt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherTarget { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherTarget { get; init; } 
    #else
    public System.String? OtherTarget { get; set; } 
    #endif
    
    /// <summary>
    /// Format of the additional information.
    /// </summary>
    [IsoId("_KjaXUEXZEeegp_DADCe7HQ")]
    [DisplayName("Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frmt")]
    #endif
    [IsoXmlTag("Frmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OutputFormat4Code? Format { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OutputFormat4Code? Format { get; init; } 
    #else
    public OutputFormat4Code? Format { get; set; } 
    #endif
    
    /// <summary>
    /// Other output format.
    /// </summary>
    [IsoId("_CEF_MFKeEeeFcfYfFkVztg")]
    [DisplayName("Other Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrFrmt")]
    #endif
    [IsoXmlTag("OthrFrmt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherFormat { get; init; } 
    #else
    public System.String? OtherFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the type of the value.
    /// </summary>
    [IsoId("_RGBF4Bs4EeqrvK3udMUsNQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Type { get; init; } 
    #else
    public System.String? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Content of or reference to the message.
    /// </summary>
    [IsoId("_vuWMoewlEeiMkKo2clXHdQ")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max20KText)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20KText Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Value { get; init; } 
    #else
    public System.String Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}
