// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Details of the underlying of a security transaction.
    /// </summary>
    [KnownType(typeof(UnderlyingIdentification3Choice.Swap))]
    [KnownType(typeof(UnderlyingIdentification3Choice.Other))]
    [JsonDerivedType(typeof(UnderlyingIdentification3Choice.Swap),nameof(UnderlyingIdentification3Choice.Swap))]
    [JsonDerivedType(typeof(UnderlyingIdentification3Choice.Other),nameof(UnderlyingIdentification3Choice.Other))]
    [IsoId("_1tAh1Z3DEeuwmdq0KtnICg")]
    [DisplayName("Underlying Identification 3 Choice")]
    public abstract partial record UnderlyingIdentification3Choice_
    {
    }
}
