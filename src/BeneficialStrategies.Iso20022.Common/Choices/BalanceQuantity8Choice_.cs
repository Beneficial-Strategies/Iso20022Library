// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between quantity formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity8Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity8Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BalanceQuantity8Choice.Quantity),
        nameof(BalanceQuantity8Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(BalanceQuantity8Choice.Proprietary),
        nameof(BalanceQuantity8Choice.Proprietary)
    )]
    [IsoId("_KPs90TnGEeWV5sr121Fc8A")]
    [DisplayName("Balance Quantity 8 Choice")]
    public abstract record BalanceQuantity8Choice_ { }
}
