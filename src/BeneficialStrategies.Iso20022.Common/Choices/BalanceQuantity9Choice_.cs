// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between quantity formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity9Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity9Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceQuantity9Choice.Quantity),nameof(BalanceQuantity9Choice.Quantity))]
    [JsonDerivedType(typeof(BalanceQuantity9Choice.Proprietary),nameof(BalanceQuantity9Choice.Proprietary))]
    [IsoId("_Pg05QznGEeWV5sr121Fc8A")]
    [DisplayName("Balance Quantity 9 Choice")]
    public abstract partial record BalanceQuantity9Choice_
    {
    }
}
