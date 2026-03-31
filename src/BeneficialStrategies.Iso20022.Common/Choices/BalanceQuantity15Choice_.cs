// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between quantity formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity15Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity15Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BalanceQuantity15Choice.Quantity),
        nameof(BalanceQuantity15Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(BalanceQuantity15Choice.Proprietary),
        nameof(BalanceQuantity15Choice.Proprietary)
    )]
    [IsoId("_ch9l1Ti8Eeydid5dcNPKvg")]
    [DisplayName("Balance Quantity 15 Choice")]
    public abstract record BalanceQuantity15Choice_ { }
}
