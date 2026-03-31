// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement type.
    /// </summary>
    [KnownType(typeof(StatementType6Choice.Code))]
    [KnownType(typeof(StatementType6Choice.Proprietary))]
    [JsonDerivedType(typeof(StatementType6Choice.Code), nameof(StatementType6Choice.Code))]
    [JsonDerivedType(
        typeof(StatementType6Choice.Proprietary),
        nameof(StatementType6Choice.Proprietary)
    )]
    [IsoId("_8QbnrZNLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Type 6 Choice")]
    public abstract record StatementType6Choice_ { }
}
