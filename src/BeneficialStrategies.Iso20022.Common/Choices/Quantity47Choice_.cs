// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the format of the quantity of delivery.
    /// </summary>
    [KnownType(typeof(Quantity47Choice.Quantity))]
    [KnownType(typeof(Quantity47Choice.Description))]
    [JsonDerivedType(typeof(Quantity47Choice.Quantity),nameof(Quantity47Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity47Choice.Description),nameof(Quantity47Choice.Description))]
    [IsoId("_b_ddkZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Quantity 47 Choice")]
    public abstract partial record Quantity47Choice_
    {
    }
}
