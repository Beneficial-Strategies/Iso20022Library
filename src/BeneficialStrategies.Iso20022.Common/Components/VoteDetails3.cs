// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies detailed voting instructions.
/// </summary>
[IsoId("_hU-5QV66EeSjaerr_EM7AQ")]
[DisplayName("Vote Details")]
public partial record VoteDetails3
{
    #nullable enable
    
    /// <summary>
    /// Indicates the vote instruction for the resolutions that are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    [IsoId("_hx10Y166EeSjaerr_EM7AQ")]
    [DisplayName("Vote Instruction For Agenda Resolution")]
    [IsoXmlTag("VoteInstrForAgndRsltn")]
    public required Vote3Choice_ VoteInstructionForAgendaResolution { get; init; } 
    
    /// <summary>
    /// Indicates the vote instruction for the resolutions that may arise at the meeting but were not previously provided in the agenda.
    /// </summary>
    [IsoId("_hx10ZV66EeSjaerr_EM7AQ")]
    [DisplayName("Vote Instruction For Meeting Resolution")]
    [IsoXmlTag("VoteInstrForMtgRsltn")]
    public VoteInstructionForMeetingResolution2Choice_? VoteInstructionForMeetingResolution { get; init; } 
    
    
    #nullable disable
    
}
