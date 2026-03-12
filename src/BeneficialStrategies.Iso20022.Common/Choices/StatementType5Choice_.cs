// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement type.
    /// </summary>
    [KnownType(typeof(StatementType5Choice.Code))]
    [KnownType(typeof(StatementType5Choice.Proprietary))]
    [JsonDerivedType(typeof(StatementType5Choice.Code),nameof(StatementType5Choice.Code))]
    [JsonDerivedType(typeof(StatementType5Choice.Proprietary),nameof(StatementType5Choice.Proprietary))]
    [IsoId("_ufLsETqoEeWyoP0PbocV1Q")]
    [DisplayName("Statement Type 5 Choice")]
    public abstract partial record StatementType5Choice_
    {
    }
}
