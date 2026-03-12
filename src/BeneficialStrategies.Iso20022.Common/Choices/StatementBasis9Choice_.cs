// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement basis.
    /// </summary>
    [KnownType(typeof(StatementBasis9Choice.Code))]
    [KnownType(typeof(StatementBasis9Choice.Proprietary))]
    [JsonDerivedType(typeof(StatementBasis9Choice.Code),nameof(StatementBasis9Choice.Code))]
    [JsonDerivedType(typeof(StatementBasis9Choice.Proprietary),nameof(StatementBasis9Choice.Proprietary))]
    [IsoId("_5Wx6LpNLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Basis 9 Choice")]
    public abstract partial record StatementBasis9Choice_
    {
    }
}
