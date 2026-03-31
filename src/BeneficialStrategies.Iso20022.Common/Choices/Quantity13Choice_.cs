// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Total quantity of securities to be transferred, expressed in a number of units or a percentage rate.
    /// </summary>
    [KnownType(typeof(Quantity13Choice.TotalUnitsNumber))]
    [KnownType(typeof(Quantity13Choice.PortfolioTransferOutRate))]
    [JsonDerivedType(
        typeof(Quantity13Choice.TotalUnitsNumber),
        nameof(Quantity13Choice.TotalUnitsNumber)
    )]
    [JsonDerivedType(
        typeof(Quantity13Choice.PortfolioTransferOutRate),
        nameof(Quantity13Choice.PortfolioTransferOutRate)
    )]
    [IsoId("__UhkwEZ6EeGxeZmLCxTaOw_-2052413231")]
    [DisplayName("Quantity 13 Choice")]
    public abstract record Quantity13Choice_ { }
}
