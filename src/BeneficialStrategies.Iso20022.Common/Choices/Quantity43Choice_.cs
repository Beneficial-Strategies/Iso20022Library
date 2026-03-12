// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of quantity of assets to be transferred in percentage rate or units.
    /// </summary>
    [KnownType(typeof(Quantity43Choice.Unit))]
    [KnownType(typeof(Quantity43Choice.PercentageRate))]
    [JsonDerivedType(typeof(Quantity43Choice.Unit),nameof(Quantity43Choice.Unit))]
    [JsonDerivedType(typeof(Quantity43Choice.PercentageRate),nameof(Quantity43Choice.PercentageRate))]
    [IsoId("_pzAI0a5xEeeMy7TnJ3e__g")]
    [DisplayName("Quantity 43 Choice")]
    public abstract partial record Quantity43Choice_
    {
    }
}
