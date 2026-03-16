// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a set amount or a percentage.
    /// </summary>
    [KnownType(typeof(AmountOrPercentage2Choice.Amount))]
    [KnownType(typeof(AmountOrPercentage2Choice.Percentage))]
    [JsonDerivedType(
        typeof(AmountOrPercentage2Choice.Amount),
        nameof(AmountOrPercentage2Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(AmountOrPercentage2Choice.Percentage),
        nameof(AmountOrPercentage2Choice.Percentage)
    )]
    [IsoId("_3CRsENP8EeK0PPbKncCqzA")]
    [DisplayName("Amount Or Percentage 2 Choice")]
    public abstract record AmountOrPercentage2Choice_ { }
}
