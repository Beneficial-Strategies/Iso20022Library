// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the name prefix.
    /// </summary>
    [KnownType(typeof(NamePrefix1Choice.Code))]
    [KnownType(typeof(NamePrefix1Choice.Proprietary))]
    [JsonDerivedType(typeof(NamePrefix1Choice.Code),nameof(NamePrefix1Choice.Code))]
    [JsonDerivedType(typeof(NamePrefix1Choice.Proprietary),nameof(NamePrefix1Choice.Proprietary))]
    [IsoId("_rzAroCiEEeKVDZ5HKjI6bg")]
    [DisplayName("Name Prefix 1 Choice")]
    public abstract partial record NamePrefix1Choice_
    {
    }
}
