// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the termination date.
    /// </summary>
    [KnownType(typeof(TerminationDate4Choice.Date))]
    [KnownType(typeof(TerminationDate4Choice.Code))]
    [JsonDerivedType(typeof(TerminationDate4Choice.Date), nameof(TerminationDate4Choice.Date))]
    [JsonDerivedType(typeof(TerminationDate4Choice.Code), nameof(TerminationDate4Choice.Code))]
    [IsoId("_ZMYZoTqkEeWyoP0PbocV1Q")]
    [DisplayName("Termination Date 4 Choice")]
    public abstract record TerminationDate4Choice_ { }
}
