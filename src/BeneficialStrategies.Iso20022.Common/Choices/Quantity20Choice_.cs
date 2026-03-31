// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats of securities quantity.
    /// </summary>
    [KnownType(typeof(Quantity20Choice.Code))]
    [KnownType(typeof(Quantity20Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity20Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity20Choice.Code), nameof(Quantity20Choice.Code))]
    [JsonDerivedType(
        typeof(Quantity20Choice.OriginalAndCurrentFaceAmount),
        nameof(Quantity20Choice.OriginalAndCurrentFaceAmount)
    )]
    [JsonDerivedType(typeof(Quantity20Choice.Quantity), nameof(Quantity20Choice.Quantity))]
    [IsoId("_BKblj0GUEeWqy4niLuXETA")]
    [DisplayName("Quantity 20 Choice")]
    public abstract record Quantity20Choice_ { }
}
