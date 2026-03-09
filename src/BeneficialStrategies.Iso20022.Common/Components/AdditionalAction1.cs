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
/// Additional action to perform.
/// </summary>
[IsoId("_rz-88EXVEeegp_DADCe7HQ")]
[DisplayName("Additional Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalAction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of additional action to perform.
    /// </summary>
    [IsoId("__xUOEEXVEeegp_DADCe7HQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionType10Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionType10Code? Type { get; init; } 
    #else
    public ActionType10Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Destination of the additional action to perform.
    /// </summary>
    [IsoId("_E87XUEXWEeegp_DADCe7HQ")]
    [DisplayName("Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dstn")]
    #endif
    [IsoXmlTag("Dstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyType21Code? Destination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType21Code? Destination { get; init; } 
    #else
    public PartyType21Code? Destination { get; set; } 
    #endif
    
    /// <summary>
    /// Other destination of action.
    /// </summary>
    [IsoId("_Hk9cMFKdEeeFcfYfFkVztg")]
    [DisplayName("Other Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDstn")]
    #endif
    [IsoXmlTag("OthrDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherDestination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherDestination { get; init; } 
    #else
    public System.String? OtherDestination { get; set; } 
    #endif
    
    /// <summary>
    /// Type of destination of the additional action to perform.
    /// </summary>
    [IsoId("_LyI7oEXWEeegp_DADCe7HQ")]
    [DisplayName("Destination Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstnTp")]
    #endif
    [IsoXmlTag("DstnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionDestination1Code? DestinationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionDestination1Code? DestinationType { get; init; } 
    #else
    public ActionDestination1Code? DestinationType { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of destination.
    /// </summary>
    [IsoId("_W88S0FKdEeeFcfYfFkVztg")]
    [DisplayName("Other Destination Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDstnTp")]
    #endif
    [IsoXmlTag("OthrDstnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherDestinationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherDestinationType { get; init; } 
    #else
    public System.String? OtherDestinationType { get; set; } 
    #endif
    
    /// <summary>
    /// Physical destination address of the additional action to perform (for example, URL, mobile phone number, IP address, file name, etc.).
    /// </summary>
    [IsoId("_aK9bUEXWEeegp_DADCe7HQ")]
    [DisplayName("Destination Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstnAdr")]
    #endif
    [IsoXmlTag("DstnAdr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? DestinationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DestinationAddress { get; init; } 
    #else
    public System.String? DestinationAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Format of the message associated with the additional action to perform.
    /// </summary>
    [IsoId("_gy7N0EXWEeegp_DADCe7HQ")]
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
    /// Other type of format for action data.
    /// </summary>
    [IsoId("_kIV9IFKdEeeFcfYfFkVztg")]
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
    /// Content of or reference to the message.
    /// </summary>
    [IsoId("_REnvoEXbEeegp_DADCe7HQ")]
    [DisplayName("Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntt")]
    #endif
    [IsoXmlTag("Cntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Content1? Content { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Content1? Content { get; init; } 
    #else
    public Content1? Content { get; set; } 
    #endif
    
    
    #nullable disable
    
}
