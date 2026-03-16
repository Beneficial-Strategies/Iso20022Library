// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the balance information.
    /// </summary>
    [KnownType(typeof(SubBalanceQuantity5Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SubBalanceQuantity5Choice.Quantity),
        nameof(SubBalanceQuantity5Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(SubBalanceQuantity5Choice.Proprietary),
        nameof(SubBalanceQuantity5Choice.Proprietary)
    )]
    [IsoId("_01_3kYjvEeONZKAAW4pOaQ")]
    [DisplayName("Sub Balance Quantity 5 Choice")]
    public abstract record SubBalanceQuantity5Choice_ { }
}
