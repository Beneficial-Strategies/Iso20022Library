// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat17Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat17Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionFeaturesFormat17Choice.Code),nameof(OptionFeaturesFormat17Choice.Code))]
    [JsonDerivedType(typeof(OptionFeaturesFormat17Choice.Proprietary),nameof(OptionFeaturesFormat17Choice.Proprietary))]
    [IsoId("_2S0R0UGKEeWqy4niLuXETA")]
    [DisplayName("Option Features Format 17 Choice")]
    public abstract partial record OptionFeaturesFormat17Choice_
    {
    }
}
