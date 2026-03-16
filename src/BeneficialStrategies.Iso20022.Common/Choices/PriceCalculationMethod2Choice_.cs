// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Calculation Method2Choice.
    /// </summary>
    [KnownType(typeof(PriceCalculationMethod2Choice.Code))]
    [KnownType(typeof(PriceCalculationMethod2Choice.Proprietary))]
    [JsonDerivedType(typeof(PriceCalculationMethod2Choice.Code),nameof(PriceCalculationMethod2Choice.Code))]
    [JsonDerivedType(typeof(PriceCalculationMethod2Choice.Proprietary),nameof(PriceCalculationMethod2Choice.Proprietary))]
    [IsoId("_HlKRQ6GoEe-4O7NbwmwJkQ")]
    [DisplayName("Price Calculation Method2Choice")]
    public abstract partial record PriceCalculationMethod2Choice_
    {
    }
}
