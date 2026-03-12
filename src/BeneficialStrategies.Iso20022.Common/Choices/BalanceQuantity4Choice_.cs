// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between quantity formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity4Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity4Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceQuantity4Choice.Quantity),nameof(BalanceQuantity4Choice.Quantity))]
    [JsonDerivedType(typeof(BalanceQuantity4Choice.Proprietary),nameof(BalanceQuantity4Choice.Proprietary))]
    [IsoId("_QYeIatp-Ed-ak6NoX_4Aeg_-2105698154")]
    [DisplayName("Balance Quantity 4 Choice")]
    public abstract partial record BalanceQuantity4Choice_
    {
    }
}
