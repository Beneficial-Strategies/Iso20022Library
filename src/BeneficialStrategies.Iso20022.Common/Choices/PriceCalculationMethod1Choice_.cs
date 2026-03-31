// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Calculation Method1Choice.
    /// </summary>
    [KnownType(typeof(PriceCalculationMethod1Choice.Code))]
    [KnownType(typeof(PriceCalculationMethod1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PriceCalculationMethod1Choice.Code),
        nameof(PriceCalculationMethod1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PriceCalculationMethod1Choice.Proprietary),
        nameof(PriceCalculationMethod1Choice.Proprietary)
    )]
    [IsoId("_3E9TM4DKEe-eGe8fbP3Zug")]
    [DisplayName("Price Calculation Method1Choice")]
    public abstract record PriceCalculationMethod1Choice_ { }
}
