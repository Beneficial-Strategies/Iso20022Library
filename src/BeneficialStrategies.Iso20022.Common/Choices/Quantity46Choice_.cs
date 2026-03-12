// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the format of the quantity of delivery.
    /// </summary>
    [KnownType(typeof(Quantity46Choice.Quantity))]
    [KnownType(typeof(Quantity46Choice.Description))]
    [JsonDerivedType(typeof(Quantity46Choice.Quantity),nameof(Quantity46Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity46Choice.Description),nameof(Quantity46Choice.Description))]
    [IsoId("_2vwJoZCuEeic-NeLxeO3hQ")]
    [DisplayName("Quantity 46 Choice")]
    public abstract partial record Quantity46Choice_
    {
    }
}
