// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the balance information.
    /// </summary>
    [KnownType(typeof(SubBalanceQuantity3Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity3Choice.Proprietary))]
    [KnownType(typeof(SubBalanceQuantity3Choice.QuantityAndAvailability))]
    [JsonDerivedType(
        typeof(SubBalanceQuantity3Choice.Quantity),
        nameof(SubBalanceQuantity3Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(SubBalanceQuantity3Choice.Proprietary),
        nameof(SubBalanceQuantity3Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(SubBalanceQuantity3Choice.QuantityAndAvailability),
        nameof(SubBalanceQuantity3Choice.QuantityAndAvailability)
    )]
    [IsoId("_QYLNfNp-Ed-ak6NoX_4Aeg_-1938942383")]
    [DisplayName("Sub Balance Quantity 3 Choice")]
    public abstract record SubBalanceQuantity3Choice_ { }
}
