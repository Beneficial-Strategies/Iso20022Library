// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of additional right threshold.
    /// </summary>
    [KnownType(typeof(AdditionalRightThreshold1Choice.AdditionalRightThreshold))]
    [KnownType(typeof(AdditionalRightThreshold1Choice.AdditionalRightThresholdPercentage))]
    [JsonDerivedType(typeof(AdditionalRightThreshold1Choice.AdditionalRightThreshold),nameof(AdditionalRightThreshold1Choice.AdditionalRightThreshold))]
    [JsonDerivedType(typeof(AdditionalRightThreshold1Choice.AdditionalRightThresholdPercentage),nameof(AdditionalRightThreshold1Choice.AdditionalRightThresholdPercentage))]
    [IsoId("_RDrok9p-Ed-ak6NoX_4Aeg_1316358552")]
    [DisplayName("Additional Right Threshold 1 Choice")]
    public abstract partial record AdditionalRightThreshold1Choice_
    {
    }
}
