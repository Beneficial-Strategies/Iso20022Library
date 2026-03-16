// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

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
    [JsonDerivedType(
        typeof(SequenceRange1Choice.FromSequence),
        nameof(SequenceRange1Choice.FromSequence)
    )]
    [JsonDerivedType(
        typeof(SequenceRange1Choice.ToSequence),
        nameof(SequenceRange1Choice.ToSequence)
    )]
    [JsonDerivedType(
        typeof(SequenceRange1Choice.FromToSequence),
        nameof(SequenceRange1Choice.FromToSequence)
    )]
    [JsonDerivedType(
        typeof(SequenceRange1Choice.EqualSequence),
        nameof(SequenceRange1Choice.EqualSequence)
    )]
    [JsonDerivedType(
        typeof(SequenceRange1Choice.NotEqualSequence),
        nameof(SequenceRange1Choice.NotEqualSequence)
    )]
    [IsoId("_rsIb84y3EeeGkvZr3jtnCQ")]
    [DisplayName("Sequence Range 1 Choice")]
    public abstract record SequenceRange1Choice_ { }
}
