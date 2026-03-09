// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Vote instruction applying to resolutions added during the meeting.
    /// </summary>
    [KnownType(typeof(VoteInstructionForMeetingResolution3Choice.VoteIndication))]
    [KnownType(typeof(VoteInstructionForMeetingResolution3Choice.Shareholder))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(VoteInstructionForMeetingResolution3Choice.VoteIndication),nameof(VoteInstructionForMeetingResolution3Choice.VoteIndication))]
    [JsonDerivedType(typeof(VoteInstructionForMeetingResolution3Choice.Shareholder),nameof(VoteInstructionForMeetingResolution3Choice.Shareholder))]
    #endif
    [IsoId("_nguqQa4dEemG7MmivSuE5g")]
    [DisplayName("Vote Instruction For Meeting Resolution 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record VoteInstructionForMeetingResolution3Choice_
    #else
    public abstract partial class VoteInstructionForMeetingResolution3Choice_
    #endif
    {
    }
}
