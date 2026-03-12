// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement basis.
    /// </summary>
    [KnownType(typeof(StatementBasis12Choice.Code))]
    [KnownType(typeof(StatementBasis12Choice.Proprietary))]
    [JsonDerivedType(typeof(StatementBasis12Choice.Code),nameof(StatementBasis12Choice.Code))]
    [JsonDerivedType(typeof(StatementBasis12Choice.Proprietary),nameof(StatementBasis12Choice.Proprietary))]
    [IsoId("_8bgPd5NLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Basis 12 Choice")]
    public abstract partial record StatementBasis12Choice_
    {
    }
}
