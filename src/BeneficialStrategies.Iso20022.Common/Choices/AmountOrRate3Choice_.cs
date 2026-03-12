// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or rate.
    /// </summary>
    [KnownType(typeof(AmountOrRate3Choice.Amount))]
    [KnownType(typeof(AmountOrRate3Choice.Rate))]
    [JsonDerivedType(typeof(AmountOrRate3Choice.Amount),nameof(AmountOrRate3Choice.Amount))]
    [JsonDerivedType(typeof(AmountOrRate3Choice.Rate),nameof(AmountOrRate3Choice.Rate))]
    [IsoId("_cL-fQQauEeS3lpTattq7hg")]
    [DisplayName("Amount Or Rate 3 Choice")]
    public abstract partial record AmountOrRate3Choice_
    {
    }
}
