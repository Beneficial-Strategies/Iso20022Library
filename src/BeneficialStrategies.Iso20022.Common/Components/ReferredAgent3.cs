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
/// Provides the placement agent identification for a hedge fund if the investor was referred by one.
/// </summary>
[IsoId("_hyxAAZRBEemqYPWMBuVawg")]
[DisplayName("Referred Agent")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReferredAgent3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReferredAgent3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReferredAgent3( Referred1Code reqReferred )
    {
        Referred = reqReferred;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates if the investor was referred by a placement agent.
    /// </summary>
    [IsoId("_iGjes5RBEemqYPWMBuVawg")]
    [DisplayName("Referred")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rfrd")]
    #endif
    [IsoXmlTag("Rfrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Referred1Code Referred { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Referred1Code Referred { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Referred1Code Referred { get; init; } 
    #else
    public Referred1Code Referred { get; set; } 
    #endif
    
    /// <summary>
    /// Placement agent that referred the investor.
    /// </summary>
    [IsoId("_iGjetZRBEemqYPWMBuVawg")]
    [DisplayName("Referred Placement Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RfrdPlcmntAgt")]
    #endif
    [IsoXmlTag("RfrdPlcmntAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification125Choice_? ReferredPlacementAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification125Choice_? ReferredPlacementAgent { get; init; } 
    #else
    public PartyIdentification125Choice_? ReferredPlacementAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
