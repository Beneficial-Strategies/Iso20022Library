// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Additional Right Threshold2Choice.
    /// </summary>
    [KnownType(typeof(AdditionalRightThreshold2Choice.AdditionalRightThreshold))]
    [KnownType(typeof(AdditionalRightThreshold2Choice.AdditionalRightThresholdPercentage))]
    [JsonDerivedType(typeof(AdditionalRightThreshold2Choice.AdditionalRightThreshold),nameof(AdditionalRightThreshold2Choice.AdditionalRightThreshold))]
    [JsonDerivedType(typeof(AdditionalRightThreshold2Choice.AdditionalRightThresholdPercentage),nameof(AdditionalRightThreshold2Choice.AdditionalRightThresholdPercentage))]
    [IsoId("_ddxGe5K5Ee-l-O3vIHRmRw")]
    [DisplayName("Additional Right Threshold2Choice")]
    public abstract partial record AdditionalRightThreshold2Choice_
    {
    }
}
