// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement basis.
    /// </summary>
    [KnownType(typeof(StatementBasis8Choice.Code))]
    [KnownType(typeof(StatementBasis8Choice.Proprietary))]
    [JsonDerivedType(typeof(StatementBasis8Choice.Code), nameof(StatementBasis8Choice.Code))]
    [JsonDerivedType(
        typeof(StatementBasis8Choice.Proprietary),
        nameof(StatementBasis8Choice.Proprietary)
    )]
    [IsoId("_a5kwgTp-EeWVrPy0StzzSg")]
    [DisplayName("Statement Basis 8 Choice")]
    public abstract record StatementBasis8Choice_ { }
}
