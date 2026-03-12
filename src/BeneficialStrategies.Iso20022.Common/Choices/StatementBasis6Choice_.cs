// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement basis.
    /// </summary>
    [KnownType(typeof(StatementBasis6Choice.Code))]
    [KnownType(typeof(StatementBasis6Choice.Proprietary))]
    [JsonDerivedType(typeof(StatementBasis6Choice.Code),nameof(StatementBasis6Choice.Code))]
    [JsonDerivedType(typeof(StatementBasis6Choice.Proprietary),nameof(StatementBasis6Choice.Proprietary))]
    [IsoId("_nAFOcPNBEeCuA5Tr22BnwA_192317835")]
    [DisplayName("Statement Basis 6 Choice")]
    public abstract partial record StatementBasis6Choice_
    {
    }
}
