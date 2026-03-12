// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or a rate.
    /// </summary>
    [KnownType(typeof(AmountOrRate4Choice.Amount))]
    [KnownType(typeof(AmountOrRate4Choice.Rate))]
    [JsonDerivedType(typeof(AmountOrRate4Choice.Amount),nameof(AmountOrRate4Choice.Amount))]
    [JsonDerivedType(typeof(AmountOrRate4Choice.Rate),nameof(AmountOrRate4Choice.Rate))]
    [IsoId("_xN0ggANwEe2-vqzwMUAewg")]
    [DisplayName("Amount Or Rate 4 Choice")]
    public abstract partial record AmountOrRate4Choice_
    {
    }
}
