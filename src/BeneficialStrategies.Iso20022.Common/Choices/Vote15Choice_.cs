// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a vote per agenda resolution and vote for all agenda resolutions.
    /// </summary>
    [KnownType(typeof(Vote15Choice.VotePerAgendaResolution))]
    [KnownType(typeof(Vote15Choice.VoteForAllAgendaResolutions))]
    [JsonDerivedType(typeof(Vote15Choice.VotePerAgendaResolution),nameof(Vote15Choice.VotePerAgendaResolution))]
    [JsonDerivedType(typeof(Vote15Choice.VoteForAllAgendaResolutions),nameof(Vote15Choice.VoteForAllAgendaResolutions))]
    [IsoId("_9DJBZ_NXEeqRfth943bvEA")]
    [DisplayName("Vote 15 Choice")]
    public abstract partial record Vote15Choice_
    {
    }
}
