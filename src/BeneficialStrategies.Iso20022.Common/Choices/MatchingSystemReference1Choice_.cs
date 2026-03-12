// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a matching system unique identification or the related reference.
    /// </summary>
    [KnownType(typeof(MatchingSystemReference1Choice.MatchingSystemUniqueReference))]
    [KnownType(typeof(MatchingSystemReference1Choice.RelatedReference))]
    [JsonDerivedType(typeof(MatchingSystemReference1Choice.MatchingSystemUniqueReference),nameof(MatchingSystemReference1Choice.MatchingSystemUniqueReference))]
    [JsonDerivedType(typeof(MatchingSystemReference1Choice.RelatedReference),nameof(MatchingSystemReference1Choice.RelatedReference))]
    [IsoId("_i-a184ufEeKYr_965Eh8aQ")]
    [DisplayName("Matching System Reference 1 Choice")]
    public abstract partial record MatchingSystemReference1Choice_
    {
    }
}
