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
    [KnownType(typeof(VoteInstructionForMeetingResolution1Choice.VoteIndication))]
    [KnownType(typeof(VoteInstructionForMeetingResolution1Choice.Shareholder))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(VoteInstructionForMeetingResolution1Choice.VoteIndication),nameof(VoteInstructionForMeetingResolution1Choice.VoteIndication))]
    [JsonDerivedType(typeof(VoteInstructionForMeetingResolution1Choice.Shareholder),nameof(VoteInstructionForMeetingResolution1Choice.Shareholder))]
    #endif
    [IsoId("_TK1iUNp-Ed-ak6NoX_4Aeg_853994638")]
    [DisplayName("Vote Instruction For Meeting Resolution 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record VoteInstructionForMeetingResolution1Choice_
    #else
    public abstract partial class VoteInstructionForMeetingResolution1Choice_
    #endif
    {
    }
}
