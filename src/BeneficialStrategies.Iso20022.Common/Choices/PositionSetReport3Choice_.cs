// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Statistics per counterparty reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(PositionSetReport3Choice.DataSetAction))]
    [KnownType(typeof(PositionSetReport3Choice.Report))]
    [JsonDerivedType(
        typeof(PositionSetReport3Choice.DataSetAction),
        nameof(PositionSetReport3Choice.DataSetAction)
    )]
    [JsonDerivedType(
        typeof(PositionSetReport3Choice.Report),
        nameof(PositionSetReport3Choice.Report)
    )]
    [IsoId("_0loGgcKwEeuM4pgP8Vixbg")]
    [DisplayName("Position Set Report 3 Choice")]
    public abstract record PositionSetReport3Choice_ { }
}
