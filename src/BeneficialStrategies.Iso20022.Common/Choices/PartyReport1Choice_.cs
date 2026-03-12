// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Report of the relevant institution. The report can be either an update or a cancellation.
    /// </summary>
    [KnownType(typeof(PartyReport1Choice.Update))]
    [KnownType(typeof(PartyReport1Choice.Cancellation))]
    [JsonDerivedType(typeof(PartyReport1Choice.Update),nameof(PartyReport1Choice.Update))]
    [JsonDerivedType(typeof(PartyReport1Choice.Cancellation),nameof(PartyReport1Choice.Cancellation))]
    [IsoId("_77i8YDbtEeeYhaZ6bvG1Xg")]
    [DisplayName("Party Report 1 Choice")]
    public abstract partial record PartyReport1Choice_
    {
    }
}
