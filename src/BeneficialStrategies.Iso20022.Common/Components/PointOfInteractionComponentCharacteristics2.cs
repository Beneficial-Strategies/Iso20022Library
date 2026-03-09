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
/// Physical and logical characteristics of a POI component (Point of Interaction).
/// </summary>
[IsoId("_c4on0S9QEeOlZIh7PImd0A")]
[DisplayName("Point Of Interaction Component Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionComponentCharacteristics2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Memory characteristics of the component.
    /// </summary>
    [IsoId("_dJS6AS9QEeOlZIh7PImd0A")]
    [DisplayName("Memory")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mmry")]
    #endif
    [IsoXmlTag("Mmry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MemoryCharacteristics1? Memory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MemoryCharacteristics1? Memory { get; init; } 
    #else
    public MemoryCharacteristics1? Memory { get; set; } 
    #endif
    
    /// <summary>
    /// Low level communication of the hardware or software component toward another component or an external entity.
    /// </summary>
    [IsoId("_dJS6Ay9QEeOlZIh7PImd0A")]
    [DisplayName("Communication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Com")]
    #endif
    [IsoXmlTag("Com")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationCharacteristics2? Communication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationCharacteristics2? Communication { get; init; } 
    #else
    public CommunicationCharacteristics2? Communication { get; set; } 
    #endif
    
    /// <summary>
    /// Number of security access modules (SAM).
    /// </summary>
    [IsoId("_dJS6BS9QEeOlZIh7PImd0A")]
    [DisplayName("Security Access Modules")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyAccsMdls")]
    #endif
    [IsoXmlTag("SctyAccsMdls")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SecurityAccessModules { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SecurityAccessModules { get; init; } 
    #else
    public System.UInt64? SecurityAccessModules { get; set; } 
    #endif
    
    /// <summary>
    /// Number of subscriber identity modules (SIM).
    /// </summary>
    [IsoId("_dJS6By9QEeOlZIh7PImd0A")]
    [DisplayName("Subscriber Identity Modules")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcbrIdntyMdls")]
    #endif
    [IsoXmlTag("SbcbrIdntyMdls")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SubscriberIdentityModules { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SubscriberIdentityModules { get; init; } 
    #else
    public System.UInt64? SubscriberIdentityModules { get; set; } 
    #endif
    
    /// <summary>
    /// Value for checking a cryptographic key security parameter.
    /// </summary>
    [IsoId("_dJS6CS9QEeOlZIh7PImd0A")]
    [DisplayName("Key Check Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyChckVal")]
    #endif
    [IsoXmlTag("KeyChckVal")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Binary? KeyCheckValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? KeyCheckValue { get; init; } 
    #else
    public System.Byte[]? KeyCheckValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
