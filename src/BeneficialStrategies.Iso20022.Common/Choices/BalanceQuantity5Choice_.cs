// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between quantity formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity5Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(BalanceQuantity5Choice.Quantity),
        nameof(BalanceQuantity5Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(BalanceQuantity5Choice.Proprietary),
        nameof(BalanceQuantity5Choice.Proprietary)
    )]
    [IsoId("_QYn5Ytp-Ed-ak6NoX_4Aeg_1192196789")]
    [DisplayName("Balance Quantity 5 Choice")]
    public abstract record BalanceQuantity5Choice_ { }
}
