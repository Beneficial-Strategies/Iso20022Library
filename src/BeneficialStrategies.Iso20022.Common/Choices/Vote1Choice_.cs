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
    [KnownType(typeof(Vote1Choice.VoteInstruction))]
    [KnownType(typeof(Vote1Choice.GlobalVoteInstruction))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Vote1Choice.VoteInstruction),nameof(Vote1Choice.VoteInstruction))]
    [JsonDerivedType(typeof(Vote1Choice.GlobalVoteInstruction),nameof(Vote1Choice.GlobalVoteInstruction))]
    #endif
    [IsoId("_Rb-Mx9p-Ed-ak6NoX_4Aeg_4445857")]
    [DisplayName("Vote 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Vote1Choice_
    #else
    public abstract partial class Vote1Choice_
    #endif
    {
    }
}
