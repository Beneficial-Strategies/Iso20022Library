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
/// Specifies detailed voting instructions.
/// </summary>
[IsoId("_RDYtoNp-Ed-ak6NoX_4Aeg_1302554579")]
[DisplayName("Vote Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VoteDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VoteDetails2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VoteDetails2( Vote2Choice_ reqVoteInstructionForAgendaResolution )
    {
        VoteInstructionForAgendaResolution = reqVoteInstructionForAgendaResolution;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the vote instruction for the resolutions which are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    [IsoId("_RDYtodp-Ed-ak6NoX_4Aeg_1303474735")]
    [DisplayName("Vote Instruction For Agenda Resolution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstrForAgndRsltn")]
    #endif
    [IsoXmlTag("VoteInstrForAgndRsltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Vote2Choice_ VoteInstructionForAgendaResolution { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Vote2Choice_ VoteInstructionForAgendaResolution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Vote2Choice_ VoteInstructionForAgendaResolution { get; init; } 
    #else
    public Vote2Choice_ VoteInstructionForAgendaResolution { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the vote instruction for the resolutions that may arise at the meeting but were not previously provided in the agenda.
    /// </summary>
    [IsoId("_RDYtotp-Ed-ak6NoX_4Aeg_1302554702")]
    [DisplayName("Vote Instruction For Meeting Resolution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstrForMtgRsltn")]
    #endif
    [IsoXmlTag("VoteInstrForMtgRsltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteInstructionForMeetingResolution1Choice_? VoteInstructionForMeetingResolution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteInstructionForMeetingResolution1Choice_? VoteInstructionForMeetingResolution { get; init; } 
    #else
    public VoteInstructionForMeetingResolution1Choice_? VoteInstructionForMeetingResolution { get; set; } 
    #endif
    
    
    #nullable disable
    
}
