// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between quantity formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity12Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity12Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BalanceQuantity12Choice.Quantity),
        nameof(BalanceQuantity12Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(BalanceQuantity12Choice.Proprietary),
        nameof(BalanceQuantity12Choice.Proprietary)
    )]
    [IsoId("_5eTeU5NLEeWGlc8L7oPDIg")]
    [DisplayName("Balance Quantity 12 Choice")]
    public abstract record BalanceQuantity12Choice_ { }
}
