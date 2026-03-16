// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the balance information.
    /// </summary>
    [KnownType(typeof(SubBalanceQuantity6Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity6Choice.Proprietary))]
    [KnownType(typeof(SubBalanceQuantity6Choice.QuantityAndAvailability))]
    [JsonDerivedType(
        typeof(SubBalanceQuantity6Choice.Quantity),
        nameof(SubBalanceQuantity6Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(SubBalanceQuantity6Choice.Proprietary),
        nameof(SubBalanceQuantity6Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(SubBalanceQuantity6Choice.QuantityAndAvailability),
        nameof(SubBalanceQuantity6Choice.QuantityAndAvailability)
    )]
    [IsoId("_MLLzLznGEeWV5sr121Fc8A")]
    [DisplayName("Sub Balance Quantity 6 Choice")]
    public abstract record SubBalanceQuantity6Choice_ { }
}
