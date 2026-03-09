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
    [KnownType(typeof(VoteInstructionForMeetingResolution2Choice.VoteIndication))]
    [KnownType(typeof(VoteInstructionForMeetingResolution2Choice.Shareholder))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(VoteInstructionForMeetingResolution2Choice.VoteIndication),nameof(VoteInstructionForMeetingResolution2Choice.VoteIndication))]
    [JsonDerivedType(typeof(VoteInstructionForMeetingResolution2Choice.Shareholder),nameof(VoteInstructionForMeetingResolution2Choice.Shareholder))]
    #endif
    [IsoId("_na8OEV6-EeSjaerr_EM7AQ")]
    [DisplayName("Vote Instruction For Meeting Resolution 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record VoteInstructionForMeetingResolution2Choice_
    #else
    public abstract partial class VoteInstructionForMeetingResolution2Choice_
    #endif
    {
    }
}
