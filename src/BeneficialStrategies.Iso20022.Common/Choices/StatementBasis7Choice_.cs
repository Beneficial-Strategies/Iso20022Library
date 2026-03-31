// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement basis.
    /// </summary>
    [KnownType(typeof(StatementBasis7Choice.Code))]
    [KnownType(typeof(StatementBasis7Choice.Proprietary))]
    [JsonDerivedType(typeof(StatementBasis7Choice.Code), nameof(StatementBasis7Choice.Code))]
    [JsonDerivedType(
        typeof(StatementBasis7Choice.Proprietary),
        nameof(StatementBasis7Choice.Proprietary)
    )]
    [IsoId("_czz68TeREeWm5uvLSn0jEw")]
    [DisplayName("Statement Basis 7 Choice")]
    public abstract record StatementBasis7Choice_ { }
}
