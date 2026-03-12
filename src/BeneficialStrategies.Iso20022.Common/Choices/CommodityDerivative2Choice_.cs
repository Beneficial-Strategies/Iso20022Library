// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice for transparency calculation specific details on commodities.
    /// </summary>
    [KnownType(typeof(CommodityDerivative2Choice.Freight))]
    [KnownType(typeof(CommodityDerivative2Choice.Energy))]
    [JsonDerivedType(typeof(CommodityDerivative2Choice.Freight),nameof(CommodityDerivative2Choice.Freight))]
    [JsonDerivedType(typeof(CommodityDerivative2Choice.Energy),nameof(CommodityDerivative2Choice.Energy))]
    [IsoId("_nZzFsU-nEeiVsYLJl6hleg")]
    [DisplayName("Commodity Derivative 2 Choice")]
    public abstract partial record CommodityDerivative2Choice_
    {
    }
}
