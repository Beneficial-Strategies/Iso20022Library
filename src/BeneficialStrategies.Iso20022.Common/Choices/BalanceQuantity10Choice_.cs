// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between quantity formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity10Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity10Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BalanceQuantity10Choice.Quantity),
        nameof(BalanceQuantity10Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(BalanceQuantity10Choice.Proprietary),
        nameof(BalanceQuantity10Choice.Proprietary)
    )]
    [IsoId("_5W2Lq5NLEeWGlc8L7oPDIg")]
    [DisplayName("Balance Quantity 10 Choice")]
    public abstract record BalanceQuantity10Choice_ { }
}
