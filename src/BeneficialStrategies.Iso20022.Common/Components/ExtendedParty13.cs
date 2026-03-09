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
/// Other type of party.
/// </summary>
[IsoId("_MOiloWALEeiNMJ262H2pWg")]
[DisplayName("Extended Party")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExtendedParty13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ExtendedParty13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ExtendedParty13( GenericIdentification36 reqPartyRole,ContactAttributes5 reqOtherPartyDetails )
    {
        PartyRole = reqPartyRole;
        OtherPartyDetails = reqOtherPartyDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Role of the party.
    /// </summary>
    [IsoId("_Mema4WALEeiNMJ262H2pWg")]
    [DisplayName("Party Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyRole")]
    #endif
    [IsoXmlTag("PtyRole")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification36 PartyRole { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification36 PartyRole { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification36 PartyRole { get; init; } 
    #else
    public GenericIdentification36 PartyRole { get; set; } 
    #endif
    
    /// <summary>
    /// Identification and communication information about the party.
    /// </summary>
    [IsoId("_Mema42ALEeiNMJ262H2pWg")]
    [DisplayName("Other Party Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPtyDtls")]
    #endif
    [IsoXmlTag("OthrPtyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContactAttributes5 OtherPartyDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContactAttributes5 OtherPartyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactAttributes5 OtherPartyDetails { get; init; } 
    #else
    public ContactAttributes5 OtherPartyDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
