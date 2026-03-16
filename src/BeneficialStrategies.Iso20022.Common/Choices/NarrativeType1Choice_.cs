// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of narrative.
    /// </summary>
    [KnownType(typeof(NarrativeType1Choice.Code))]
    [KnownType(typeof(NarrativeType1Choice.Proprietary))]
    [JsonDerivedType(typeof(NarrativeType1Choice.Code), nameof(NarrativeType1Choice.Code))]
    [JsonDerivedType(
        typeof(NarrativeType1Choice.Proprietary),
        nameof(NarrativeType1Choice.Proprietary)
    )]
    [IsoId("_93HE0nltEeG7BsjMvd1mEw_-1199542784")]
    [DisplayName("Narrative Type 1 Choice")]
    public abstract record NarrativeType1Choice_ { }
}
