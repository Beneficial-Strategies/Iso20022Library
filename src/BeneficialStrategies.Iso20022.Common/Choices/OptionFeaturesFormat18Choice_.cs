// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat18Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat18Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionFeaturesFormat18Choice.Code),nameof(OptionFeaturesFormat18Choice.Code))]
    [JsonDerivedType(typeof(OptionFeaturesFormat18Choice.Proprietary),nameof(OptionFeaturesFormat18Choice.Proprietary))]
    [IsoId("_3OZ64UGLEeWqy4niLuXETA")]
    [DisplayName("Option Features Format 18 Choice")]
    public abstract partial record OptionFeaturesFormat18Choice_
    {
    }
}
