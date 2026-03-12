// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement basis.
    /// </summary>
    [KnownType(typeof(StatementBasis3Choice.Code))]
    [KnownType(typeof(StatementBasis3Choice.Proprietary))]
    [JsonDerivedType(typeof(StatementBasis3Choice.Code),nameof(StatementBasis3Choice.Code))]
    [JsonDerivedType(typeof(StatementBasis3Choice.Proprietary),nameof(StatementBasis3Choice.Proprietary))]
    [IsoId("_QrsmZNp-Ed-ak6NoX_4Aeg_-114081181")]
    [DisplayName("Statement Basis 3 Choice")]
    public abstract partial record StatementBasis3Choice_
    {
    }
}
