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
    [KnownType(typeof(Vote16Choice.VoteInstruction))]
    [KnownType(typeof(Vote16Choice.GlobalVoteInstruction))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Vote16Choice.VoteInstruction),nameof(Vote16Choice.VoteInstruction))]
    [JsonDerivedType(typeof(Vote16Choice.GlobalVoteInstruction),nameof(Vote16Choice.GlobalVoteInstruction))]
    #endif
    [IsoId("_XGdmEfNoEeqRfth943bvEA")]
    [DisplayName("Vote 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Vote16Choice_
    #else
    public abstract partial class Vote16Choice_
    #endif
    {
    }
}
