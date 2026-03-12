// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the statement souce.
    /// </summary>
    [KnownType(typeof(StatementSource1Choice.Code))]
    [KnownType(typeof(StatementSource1Choice.Proprietary))]
    [JsonDerivedType(typeof(StatementSource1Choice.Code),nameof(StatementSource1Choice.Code))]
    [JsonDerivedType(typeof(StatementSource1Choice.Proprietary),nameof(StatementSource1Choice.Proprietary))]
    [IsoId("_m_xscvNBEeCuA5Tr22BnwA_-620350624")]
    [DisplayName("Statement Source 1 Choice")]
    public abstract partial record StatementSource1Choice_
    {
    }
}
