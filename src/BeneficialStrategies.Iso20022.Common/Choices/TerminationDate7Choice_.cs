// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the termination date.
    /// </summary>
    [KnownType(typeof(TerminationDate7Choice.Date))]
    [KnownType(typeof(TerminationDate7Choice.Code))]
    [JsonDerivedType(typeof(TerminationDate7Choice.Date), nameof(TerminationDate7Choice.Date))]
    [JsonDerivedType(typeof(TerminationDate7Choice.Code), nameof(TerminationDate7Choice.Code))]
    [IsoId("_5TocY83yEee5nJBZsW8MFQ")]
    [DisplayName("Termination Date 7 Choice")]
    public abstract record TerminationDate7Choice_ { }
}
