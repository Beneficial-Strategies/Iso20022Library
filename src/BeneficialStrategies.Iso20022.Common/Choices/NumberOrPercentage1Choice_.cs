// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage and number for a threshold.
    /// </summary>
    [KnownType(typeof(NumberOrPercentage1Choice.ThresholdPercentage))]
    [KnownType(typeof(NumberOrPercentage1Choice.ThresholdNumber))]
    [JsonDerivedType(typeof(NumberOrPercentage1Choice.ThresholdPercentage),nameof(NumberOrPercentage1Choice.ThresholdPercentage))]
    [JsonDerivedType(typeof(NumberOrPercentage1Choice.ThresholdNumber),nameof(NumberOrPercentage1Choice.ThresholdNumber))]
    [IsoId("_U1n_kK4pEemG7MmivSuE5g")]
    [DisplayName("Number Or Percentage 1 Choice")]
    public abstract partial record NumberOrPercentage1Choice_
    {
    }
}
