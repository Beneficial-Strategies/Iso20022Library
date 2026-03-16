// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the termination date.
    /// </summary>
    [KnownType(typeof(TerminationDate5Choice.Date))]
    [KnownType(typeof(TerminationDate5Choice.Code))]
    [JsonDerivedType(typeof(TerminationDate5Choice.Date), nameof(TerminationDate5Choice.Date))]
    [JsonDerivedType(typeof(TerminationDate5Choice.Code), nameof(TerminationDate5Choice.Code))]
    [IsoId("_5mw3n5NLEeWGlc8L7oPDIg")]
    [DisplayName("Termination Date 5 Choice")]
    public abstract record TerminationDate5Choice_ { }
}
