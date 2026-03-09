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
/// Manufacturer configuration parameters of the point of interaction (POI).
/// </summary>
[IsoId("_yQlkAEeSEeODR7vDcYOqmg")]
[DisplayName("Payment Terminal Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTerminalParameters1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Parameters to synchronise the real time clock of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_O7L_4EeWEeODR7vDcYOqmg")]
    [DisplayName("Clock Synchronisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClckSynctn")]
    #endif
    [IsoXmlTag("ClckSynctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClockSynchronisation1? ClockSynchronisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClockSynchronisation1? ClockSynchronisation { get; init; } 
    #else
    public ClockSynchronisation1? ClockSynchronisation { get; set; } 
    #endif
    
    /// <summary>
    /// Time zone line to update in the time zone data base subset stored in the POI (Point Of Interaction). The format of the line is conform to the IANA (Internet Assigned Number Authority) time zone data base.
    /// </summary>
    [IsoId("_JFopIEeTEeODR7vDcYOqmg")]
    [DisplayName("Time Zone Line")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmZoneLine")]
    #endif
    [IsoXmlTag("TmZoneLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? TimeZoneLine { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TimeZoneLine { get; init; } 
    #else
    public System.String? TimeZoneLine { get; set; } 
    #endif
    
    /// <summary>
    /// Others manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_QbW5gEeTEeODR7vDcYOqmg")]
    [DisplayName("Other Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrParams")]
    #endif
    [IsoXmlTag("OthrParams")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10000Binary? OtherParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? OtherParameters { get; init; } 
    #else
    public System.Byte[]? OtherParameters { get; set; } 
    #endif
    
    
    #nullable disable
    
}
