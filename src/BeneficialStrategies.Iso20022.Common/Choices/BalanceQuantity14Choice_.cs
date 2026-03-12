// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between quantity formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity14Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity14Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceQuantity14Choice.Quantity),nameof(BalanceQuantity14Choice.Quantity))]
    [JsonDerivedType(typeof(BalanceQuantity14Choice.Proprietary),nameof(BalanceQuantity14Choice.Proprietary))]
    [IsoId("__AeM4Sp7EeyR9JrVGfaMKw")]
    [DisplayName("Balance Quantity 14 Choice")]
    public abstract partial record BalanceQuantity14Choice_
    {
    }
}
