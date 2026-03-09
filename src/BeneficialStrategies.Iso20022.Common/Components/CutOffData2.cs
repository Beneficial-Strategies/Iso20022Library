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
/// Contains the new, current and previous cut offs for a netting cut off held at the central system.
/// </summary>
[IsoId("_B5DK5wN1Ee2-vqzwMUAewg")]
[DisplayName("Cut Off Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CutOffData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CutOffData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CutOffData2( PartyIdentification242Choice_ reqParticipantIdentification )
    {
        ParticipantIdentification = reqParticipantIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Describes the participant receiving the net report.
    /// </summary>
    [IsoId("_B-238QN1Ee2-vqzwMUAewg")]
    [DisplayName("Participant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtcptId")]
    #endif
    [IsoXmlTag("PtcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification242Choice_ ParticipantIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification242Choice_ ParticipantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242Choice_ ParticipantIdentification { get; init; } 
    #else
    public PartyIdentification242Choice_ ParticipantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the information regarding the updated netting cut off.
    /// </summary>
    [IsoId("_B-238wN1Ee2-vqzwMUAewg")]
    [DisplayName("Netting Cut Off Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetgCutOffDtls")]
    #endif
    [IsoXmlTag("NetgCutOffDtls")]
    public ValueList<NettingCutOff2> NettingCutOffDetails { get; init; } = new ValueList<NettingCutOff2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _B-238wN1Ee2-vqzwMUAewg
    
    
    #nullable disable
    
}
