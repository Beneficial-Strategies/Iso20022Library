// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for appearance.
    /// </summary>
    [KnownType(typeof(Appearance3Choice.Code))]
    [KnownType(typeof(Appearance3Choice.Proprietary))]
    [JsonDerivedType(typeof(Appearance3Choice.Code),nameof(Appearance3Choice.Code))]
    [JsonDerivedType(typeof(Appearance3Choice.Proprietary),nameof(Appearance3Choice.Proprietary))]
    [IsoId("_dYSgleLxEeWOD7aAy2fAcA")]
    [DisplayName("Appearance 3 Choice")]
    public abstract partial record Appearance3Choice_
    {
    }
}
