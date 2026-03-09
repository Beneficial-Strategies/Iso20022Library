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
[IsoId("_IZvIoQ1KEeqjM-rxn3HuXQ")]
[DisplayName("Point Of Interaction Component Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionComponentCharacteristics6
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
    [IsoId("_ImUMEQ1KEeqjM-rxn3HuXQ")]
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
    [IsoId("_ImUzIQ1KEeqjM-rxn3HuXQ")]
    [DisplayName("Communication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Com")]
    #endif
    [IsoXmlTag("Com")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationCharacteristics5? Communication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationCharacteristics5? Communication { get; init; } 
    #else
    public CommunicationCharacteristics5? Communication { get; set; } 
    #endif
    
    /// <summary>
    /// Number of security access modules (SAM).
    /// </summary>
    [IsoId("_ImUzIw1KEeqjM-rxn3HuXQ")]
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
    [IsoId("_ImUzJQ1KEeqjM-rxn3HuXQ")]
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
    /// Security characteristics of the component.
    /// </summary>
    [IsoId("_ImUzJw1KEeqjM-rxn3HuXQ")]
    [DisplayName("Security Element")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyElmt")]
    #endif
    [IsoXmlTag("SctyElmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CryptographicKey14? SecurityElement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CryptographicKey14? SecurityElement { get; init; } 
    #else
    public CryptographicKey14? SecurityElement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
