// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the balance information.
    /// </summary>
    [KnownType(typeof(SubBalanceQuantity2Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity2Choice.Proprietary))]
    [KnownType(typeof(SubBalanceQuantity2Choice.QuantityAndAvailability))]
    [JsonDerivedType(
        typeof(SubBalanceQuantity2Choice.Quantity),
        nameof(SubBalanceQuantity2Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(SubBalanceQuantity2Choice.Proprietary),
        nameof(SubBalanceQuantity2Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(SubBalanceQuantity2Choice.QuantityAndAvailability),
        nameof(SubBalanceQuantity2Choice.QuantityAndAvailability)
    )]
    [IsoId("_QZhRQ9p-Ed-ak6NoX_4Aeg_-1518979215")]
    [DisplayName("Sub Balance Quantity 2 Choice")]
    public abstract record SubBalanceQuantity2Choice_ { }
}
