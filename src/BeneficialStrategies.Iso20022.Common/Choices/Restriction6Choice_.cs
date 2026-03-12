// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities restriction information.
    /// </summary>
    [KnownType(typeof(Restriction6Choice.Code))]
    [KnownType(typeof(Restriction6Choice.Proprietary))]
    [JsonDerivedType(typeof(Restriction6Choice.Code),nameof(Restriction6Choice.Code))]
    [JsonDerivedType(typeof(Restriction6Choice.Proprietary),nameof(Restriction6Choice.Proprietary))]
    [IsoId("_5TJ-3ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Restriction 6 Choice")]
    public abstract partial record Restriction6Choice_
    {
    }
}
