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
    [KnownType(typeof(Vote3Choice.VoteInstruction))]
    [KnownType(typeof(Vote3Choice.GlobalVoteInstruction))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Vote3Choice.VoteInstruction),nameof(Vote3Choice.VoteInstruction))]
    [JsonDerivedType(typeof(Vote3Choice.GlobalVoteInstruction),nameof(Vote3Choice.GlobalVoteInstruction))]
    #endif
    [IsoId("_hx10Z166EeSjaerr_EM7AQ")]
    [DisplayName("Vote 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Vote3Choice_
    #else
    public abstract partial class Vote3Choice_
    #endif
    {
    }
}
