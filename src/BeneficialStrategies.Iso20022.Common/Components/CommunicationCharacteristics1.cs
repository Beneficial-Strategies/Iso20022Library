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
/// Low level communication of the hardware or software component toward another component or an external entity.
/// </summary>
[IsoId("_VHsEkAyIEeKa_56Jbsi1RQ")]
[DisplayName("Communication Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommunicationCharacteristics1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CommunicationCharacteristics1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CommunicationCharacteristics1( POICommunicationType1Code reqCommunicationType,PartyType7Code reqRemoteParty,System.String reqActive )
    {
        CommunicationType = reqCommunicationType;
        RemoteParty = reqRemoteParty;
        Active = reqActive;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of low level communication.
    /// </summary>
    [IsoId("_qkpVYAyIEeKa_56Jbsi1RQ")]
    [DisplayName("Communication Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComTp")]
    #endif
    [IsoXmlTag("ComTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required POICommunicationType1Code CommunicationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required POICommunicationType1Code CommunicationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public POICommunicationType1Code CommunicationType { get; init; } 
    #else
    public POICommunicationType1Code CommunicationType { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that communicate with the current component, using this communication device.
    /// </summary>
    [IsoId("_v3PQYAyIEeKa_56Jbsi1RQ")]
    [DisplayName("Remote Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmotPty")]
    #endif
    [IsoXmlTag("RmotPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyType7Code RemoteParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyType7Code RemoteParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType7Code RemoteParty { get; init; } 
    #else
    public PartyType7Code RemoteParty { get; set; } 
    #endif
    
    /// <summary>
    /// Communication hardware is activated.
    /// </summary>
    [IsoId("_3TAeYAyIEeKa_56Jbsi1RQ")]
    [DisplayName("Active")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actv")]
    #endif
    [IsoXmlTag("Actv")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator Active { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Active { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Active { get; init; } 
    #else
    public System.String Active { get; set; } 
    #endif
    
    
    #nullable disable
    
}
