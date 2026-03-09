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
    /// Determines how the voting instructions are specified.
    /// </summary>
    [KnownType(typeof(Vote4Choice.VoteInstruction))]
    [KnownType(typeof(Vote4Choice.GlobalVoteInstruction))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Vote4Choice.VoteInstruction),nameof(Vote4Choice.VoteInstruction))]
    [JsonDerivedType(typeof(Vote4Choice.GlobalVoteInstruction),nameof(Vote4Choice.GlobalVoteInstruction))]
    #endif
    [IsoId("_YoEpa64cEemG7MmivSuE5g")]
    [DisplayName("Vote 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Vote4Choice_
    #else
    public abstract partial class Vote4Choice_
    #endif
    {
    }
}
