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
    /// Specifies a choice of sequences.
    /// </summary>
    [KnownType(typeof(SequenceRange1Choice.FromSequence))]
    [KnownType(typeof(SequenceRange1Choice.ToSequence))]
    [KnownType(typeof(SequenceRange1Choice.FromToSequence))]
    [KnownType(typeof(SequenceRange1Choice.EqualSequence))]
    [KnownType(typeof(SequenceRange1Choice.NotEqualSequence))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SequenceRange1Choice.FromSequence),nameof(SequenceRange1Choice.FromSequence))]
    [JsonDerivedType(typeof(SequenceRange1Choice.ToSequence),nameof(SequenceRange1Choice.ToSequence))]
    [JsonDerivedType(typeof(SequenceRange1Choice.FromToSequence),nameof(SequenceRange1Choice.FromToSequence))]
    [JsonDerivedType(typeof(SequenceRange1Choice.EqualSequence),nameof(SequenceRange1Choice.EqualSequence))]
    [JsonDerivedType(typeof(SequenceRange1Choice.NotEqualSequence),nameof(SequenceRange1Choice.NotEqualSequence))]
    #endif
    [IsoId("_rsIb84y3EeeGkvZr3jtnCQ")]
    [DisplayName("Sequence Range 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SequenceRange1Choice_
    #else
    public abstract partial class SequenceRange1Choice_
    #endif
    {
    }
}
