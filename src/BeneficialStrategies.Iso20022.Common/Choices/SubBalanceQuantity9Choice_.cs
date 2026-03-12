// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the balance information.
    /// </summary>
    [KnownType(typeof(SubBalanceQuantity9Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity9Choice.Proprietary))]
    [KnownType(typeof(SubBalanceQuantity9Choice.QuantityAndAvailability))]
    [JsonDerivedType(typeof(SubBalanceQuantity9Choice.Quantity),nameof(SubBalanceQuantity9Choice.Quantity))]
    [JsonDerivedType(typeof(SubBalanceQuantity9Choice.Proprietary),nameof(SubBalanceQuantity9Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceQuantity9Choice.QuantityAndAvailability),nameof(SubBalanceQuantity9Choice.QuantityAndAvailability))]
    [IsoId("_ciAo3Ti8Eeydid5dcNPKvg")]
    [DisplayName("Sub Balance Quantity 9 Choice")]
    public abstract partial record SubBalanceQuantity9Choice_
    {
    }
}
