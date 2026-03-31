// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of quantity of assets to be transferred in percentage rate or units.
    /// </summary>
    [KnownType(typeof(Quantity14Choice.Unit))]
    [KnownType(typeof(Quantity14Choice.PercentageRate))]
    [JsonDerivedType(typeof(Quantity14Choice.Unit), nameof(Quantity14Choice.Unit))]
    [JsonDerivedType(
        typeof(Quantity14Choice.PercentageRate),
        nameof(Quantity14Choice.PercentageRate)
    )]
    [IsoId("_QC990RgKEeKqWJINzXcn5g")]
    [DisplayName("Quantity 14 Choice")]
    public abstract record Quantity14Choice_ { }
}
