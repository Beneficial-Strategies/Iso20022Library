// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of quantity of assets to be transferred in percentage rate or units.
    /// </summary>
    [KnownType(typeof(Quantity12Choice.Unit))]
    [KnownType(typeof(Quantity12Choice.PercentageRate))]
    [JsonDerivedType(typeof(Quantity12Choice.Unit), nameof(Quantity12Choice.Unit))]
    [JsonDerivedType(
        typeof(Quantity12Choice.PercentageRate),
        nameof(Quantity12Choice.PercentageRate)
    )]
    [IsoId("_ioTPQ_srEeCUd_EZYqZ_Uw")]
    [DisplayName("Quantity 12 Choice")]
    public abstract record Quantity12Choice_ { }
}
