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
/// Vote instruction for an agenda or a meeting resolution.
/// </summary>
[IsoId("_ZRuqZa4cEemG7MmivSuE5g")]
[DisplayName("Vote Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VoteDetails4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VoteDetails4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VoteDetails4( Vote13Choice_ reqVoteInstructionForAgendaResolution )
    {
        VoteInstructionForAgendaResolution = reqVoteInstructionForAgendaResolution;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Vote instructions for the resolutions that are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    [IsoId("_ZmQv864cEemG7MmivSuE5g")]
    [DisplayName("Vote Instruction For Agenda Resolution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstrForAgndRsltn")]
    #endif
    [IsoXmlTag("VoteInstrForAgndRsltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Vote13Choice_ VoteInstructionForAgendaResolution { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Vote13Choice_ VoteInstructionForAgendaResolution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Vote13Choice_ VoteInstructionForAgendaResolution { get; init; } 
    #else
    public Vote13Choice_ VoteInstructionForAgendaResolution { get; set; } 
    #endif
    
    /// <summary>
    /// Vote instructions for the resolutions that may arise at the meeting but were not previously provided in the agenda.
    /// </summary>
    [IsoId("_ZmQv9a4cEemG7MmivSuE5g")]
    [DisplayName("Vote Instruction For Meeting Resolution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstrForMtgRsltn")]
    #endif
    [IsoXmlTag("VoteInstrForMtgRsltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteInstructionForMeetingResolution3Choice_? VoteInstructionForMeetingResolution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteInstructionForMeetingResolution3Choice_? VoteInstructionForMeetingResolution { get; init; } 
    #else
    public VoteInstructionForMeetingResolution3Choice_? VoteInstructionForMeetingResolution { get; set; } 
    #endif
    
    
    #nullable disable
    
}
