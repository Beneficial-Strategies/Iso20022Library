// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the termination date.
    /// </summary>
    [KnownType(typeof(TerminationDate6Choice.Date))]
    [KnownType(typeof(TerminationDate6Choice.Code))]
    [JsonDerivedType(typeof(TerminationDate6Choice.Date),nameof(TerminationDate6Choice.Date))]
    [JsonDerivedType(typeof(TerminationDate6Choice.Code),nameof(TerminationDate6Choice.Code))]
    [IsoId("_hE2NAbPvEeelzbgsFa3sqQ")]
    [DisplayName("Termination Date 6 Choice")]
    public abstract partial record TerminationDate6Choice_
    {
    }
}
