// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a party role.
    /// </summary>
    [KnownType(typeof(Role6Choice.Code))]
    [KnownType(typeof(Role6Choice.Proprietary))]
    [KnownType(typeof(Role6Choice.Text))]
    [JsonDerivedType(typeof(Role6Choice.Code),nameof(Role6Choice.Code))]
    [JsonDerivedType(typeof(Role6Choice.Proprietary),nameof(Role6Choice.Proprietary))]
    [JsonDerivedType(typeof(Role6Choice.Text),nameof(Role6Choice.Text))]
    [IsoId("_eSQcQTm9EeWV5sr121Fc8A")]
    [DisplayName("Role 6 Choice")]
    public abstract partial record Role6Choice_
    {
    }
}
