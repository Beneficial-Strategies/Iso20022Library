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
/// Voting participation method at a general meeting.
/// </summary>
[IsoId("_yhcMIa7BEemG7MmivSuE5g")]
[DisplayName("Specific Instruction Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SpecificInstructionRequest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SpecificInstructionRequest2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SpecificInstructionRequest2( ParticipationMethod1Choice_ reqParticipationMethod )
    {
        ParticipationMethod = reqParticipationMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method of voting participation to the general meeting.
    /// </summary>
    [IsoId("_eE71Ma-REemJ1NnLPsTFaw")]
    [DisplayName("Participation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtcptnMtd")]
    #endif
    [IsoXmlTag("PrtcptnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ParticipationMethod1Choice_ ParticipationMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ParticipationMethod1Choice_ ParticipationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ParticipationMethod1Choice_ ParticipationMethod { get; init; } 
    #else
    public ParticipationMethod1Choice_ ParticipationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a request to register the securities for the meeting.
    /// </summary>
    [IsoId("_y2RMpa7BEemG7MmivSuE5g")]
    [DisplayName("Securities Registration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesRegn")]
    #endif
    [IsoXmlTag("SctiesRegn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SecuritiesRegistration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesRegistration { get; init; } 
    #else
    public System.String? SecuritiesRegistration { get; set; } 
    #endif
    
    
    #nullable disable
    
}
