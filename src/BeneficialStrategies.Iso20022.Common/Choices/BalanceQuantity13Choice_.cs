// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between quantity formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity13Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity13Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceQuantity13Choice.Quantity),nameof(BalanceQuantity13Choice.Quantity))]
    [JsonDerivedType(typeof(BalanceQuantity13Choice.Proprietary),nameof(BalanceQuantity13Choice.Proprietary))]
    [IsoId("_ieYh8Sp6EeyR9JrVGfaMKw")]
    [DisplayName("Balance Quantity 13 Choice")]
    public abstract partial record BalanceQuantity13Choice_
    {
    }
}
