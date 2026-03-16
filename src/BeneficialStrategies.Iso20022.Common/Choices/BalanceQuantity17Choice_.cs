// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between quantity formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity17Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity17Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BalanceQuantity17Choice.Quantity),
        nameof(BalanceQuantity17Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(BalanceQuantity17Choice.Proprietary),
        nameof(BalanceQuantity17Choice.Proprietary)
    )]
    [IsoId("_csW4Azi8Eeydid5dcNPKvg")]
    [DisplayName("Balance Quantity 17 Choice")]
    public abstract record BalanceQuantity17Choice_ { }
}
