// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the balance information.
    /// </summary>
    [KnownType(typeof(SubBalanceQuantity1Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity1Choice.QuantityAsDSS))]
    [KnownType(typeof(SubBalanceQuantity1Choice.QuantityAndAvailability))]
    [JsonDerivedType(
        typeof(SubBalanceQuantity1Choice.Quantity),
        nameof(SubBalanceQuantity1Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(SubBalanceQuantity1Choice.QuantityAsDSS),
        nameof(SubBalanceQuantity1Choice.QuantityAsDSS)
    )]
    [JsonDerivedType(
        typeof(SubBalanceQuantity1Choice.QuantityAndAvailability),
        nameof(SubBalanceQuantity1Choice.QuantityAndAvailability)
    )]
    [IsoId("_QYn5aNp-Ed-ak6NoX_4Aeg_-1945125702")]
    [DisplayName("Sub Balance Quantity 1 Choice")]
    public abstract record SubBalanceQuantity1Choice_ { }
}
