// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a vote per agenda resolution and vote for all agenda resolutions.
    /// </summary>
    [KnownType(typeof(Vote13Choice.VotePerAgendaResolution))]
    [KnownType(typeof(Vote13Choice.VoteForAllAgendaResolutions))]
    [JsonDerivedType(typeof(Vote13Choice.VotePerAgendaResolution),nameof(Vote13Choice.VotePerAgendaResolution))]
    [JsonDerivedType(typeof(Vote13Choice.VoteForAllAgendaResolutions),nameof(Vote13Choice.VoteForAllAgendaResolutions))]
    [IsoId("_c7P-kK-4EemJ1NnLPsTFaw")]
    [DisplayName("Vote 13 Choice")]
    public abstract partial record Vote13Choice_
    {
    }
}
