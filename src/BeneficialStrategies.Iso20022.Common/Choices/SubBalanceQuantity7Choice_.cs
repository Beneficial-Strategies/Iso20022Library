// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the balance information.
    /// </summary>
    [KnownType(typeof(SubBalanceQuantity7Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity7Choice.Proprietary))]
    [KnownType(typeof(SubBalanceQuantity7Choice.QuantityAndAvailability))]
    [JsonDerivedType(
        typeof(SubBalanceQuantity7Choice.Quantity),
        nameof(SubBalanceQuantity7Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(SubBalanceQuantity7Choice.Proprietary),
        nameof(SubBalanceQuantity7Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(SubBalanceQuantity7Choice.QuantityAndAvailability),
        nameof(SubBalanceQuantity7Choice.QuantityAndAvailability)
    )]
    [IsoId("_5W52FZNLEeWGlc8L7oPDIg")]
    [DisplayName("Sub Balance Quantity 7 Choice")]
    public abstract record SubBalanceQuantity7Choice_ { }
}
