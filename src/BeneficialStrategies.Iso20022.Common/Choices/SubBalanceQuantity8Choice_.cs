// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the balance information.
    /// </summary>
    [KnownType(typeof(SubBalanceQuantity8Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity8Choice.Proprietary))]
    [KnownType(typeof(SubBalanceQuantity8Choice.QuantityAndAvailability))]
    [JsonDerivedType(typeof(SubBalanceQuantity8Choice.Quantity),nameof(SubBalanceQuantity8Choice.Quantity))]
    [JsonDerivedType(typeof(SubBalanceQuantity8Choice.Proprietary),nameof(SubBalanceQuantity8Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceQuantity8Choice.QuantityAndAvailability),nameof(SubBalanceQuantity8Choice.QuantityAndAvailability))]
    [IsoId("_kcwoQSp8EeyR9JrVGfaMKw")]
    [DisplayName("Sub Balance Quantity 8 Choice")]
    public abstract partial record SubBalanceQuantity8Choice_
    {
    }
}
