// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the quantity.
    /// </summary>
    [KnownType(typeof(Quantity54Choice.Quantity))]
    [KnownType(typeof(Quantity54Choice.OriginalAndCurrentFace))]
    [JsonDerivedType(typeof(Quantity54Choice.Quantity),nameof(Quantity54Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity54Choice.OriginalAndCurrentFace),nameof(Quantity54Choice.OriginalAndCurrentFace))]
    [IsoId("_peZb9zi7Eeydid5dcNPKvg")]
    [DisplayName("Quantity 54 Choice")]
    public abstract partial record Quantity54Choice_
    {
    }
}
