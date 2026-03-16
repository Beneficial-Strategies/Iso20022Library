// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice for transparency calculation specific details on commodities.
    /// </summary>
    [KnownType(typeof(CommodityDerivate2Choice.Freight))]
    [KnownType(typeof(CommodityDerivate2Choice.Energy))]
    [JsonDerivedType(
        typeof(CommodityDerivate2Choice.Freight),
        nameof(CommodityDerivate2Choice.Freight)
    )]
    [JsonDerivedType(
        typeof(CommodityDerivate2Choice.Energy),
        nameof(CommodityDerivate2Choice.Energy)
    )]
    [IsoId("_znH8cWlHEeaLAKoEUNsD9g")]
    [DisplayName("Commodity Derivate 2 Choice")]
    public abstract record CommodityDerivate2Choice_ { }
}
