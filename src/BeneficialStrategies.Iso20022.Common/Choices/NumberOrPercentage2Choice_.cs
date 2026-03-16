// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Number Or Percentage2Choice.
    /// </summary>
    [KnownType(typeof(NumberOrPercentage2Choice.ThresholdNumber))]
    [KnownType(typeof(NumberOrPercentage2Choice.ThresholdPercentage))]
    [JsonDerivedType(typeof(NumberOrPercentage2Choice.ThresholdNumber),nameof(NumberOrPercentage2Choice.ThresholdNumber))]
    [JsonDerivedType(typeof(NumberOrPercentage2Choice.ThresholdPercentage),nameof(NumberOrPercentage2Choice.ThresholdPercentage))]
    [IsoId("_TJVpRZK5Ee-l-O3vIHRmRw")]
    [DisplayName("Number Or Percentage2Choice")]
    public abstract partial record NumberOrPercentage2Choice_
    {
    }
}
