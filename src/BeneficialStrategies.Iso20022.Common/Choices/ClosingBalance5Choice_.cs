// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of closing balance.
    /// </summary>
    [KnownType(typeof(ClosingBalance5Choice.Final))]
    [KnownType(typeof(ClosingBalance5Choice.Intermediary))]
    [JsonDerivedType(typeof(ClosingBalance5Choice.Final), nameof(ClosingBalance5Choice.Final))]
    [JsonDerivedType(
        typeof(ClosingBalance5Choice.Intermediary),
        nameof(ClosingBalance5Choice.Intermediary)
    )]
    [IsoId("_8bhd_ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Closing Balance 5 Choice")]
    public abstract record ClosingBalance5Choice_ { }
}
