// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount and a coefficient.
    /// </summary>
    [KnownType(typeof(AmountOrCoefficientPrice2Choice.Amount))]
    [KnownType(typeof(AmountOrCoefficientPrice2Choice.AmountWithCurrency))]
    [KnownType(typeof(AmountOrCoefficientPrice2Choice.Coefficient))]
    [JsonDerivedType(typeof(AmountOrCoefficientPrice2Choice.Amount), nameof(AmountOrCoefficientPrice2Choice.Amount))]
    [JsonDerivedType(typeof(AmountOrCoefficientPrice2Choice.AmountWithCurrency), nameof(AmountOrCoefficientPrice2Choice.AmountWithCurrency))]
    [JsonDerivedType(typeof(AmountOrCoefficientPrice2Choice.Coefficient), nameof(AmountOrCoefficientPrice2Choice.Coefficient))]
    [IsoId("_Muj3AWejEeqY_MU7lK4HCA")]
    [DisplayName("AmountOrCoefficientPrice2Choice")]
    public abstract record AmountOrCoefficientPrice2Choice_ { }
}
