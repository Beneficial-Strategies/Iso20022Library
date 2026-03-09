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
/// Entity involved in an activity.
/// </summary>
[IsoId("_Q_AvW3R1EeiH1ZOt2UD8vQ")]
[DisplayName("Party And Signature")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyAndSignature3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyAndSignature3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyAndSignature3( PartyIdentification135 reqParty,SkipPayload reqSignature )
    {
        Party = reqParty;
        Signature = reqSignature;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_RJI7sXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty")]
    #endif
    [IsoXmlTag("Pty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification135 Party { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification135 Party { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135 Party { get; init; } 
    #else
    public PartyIdentification135 Party { get; set; } 
    #endif
    
    /// <summary>
    /// Signature of a party.
    /// </summary>
    [IsoId("_RJI7s3R1EeiH1ZOt2UD8vQ")]
    [DisplayName("Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgntr")]
    #endif
    [IsoXmlTag("Sgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SkipPayload Signature { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SkipPayload Signature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SkipPayload Signature { get; init; } 
    #else
    public SkipPayload Signature { get; set; } 
    #endif
    
    
    #nullable disable
    
}
