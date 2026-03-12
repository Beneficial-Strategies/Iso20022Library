// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat5Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat5Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionFeaturesFormat5Choice.Code),nameof(OptionFeaturesFormat5Choice.Code))]
    [JsonDerivedType(typeof(OptionFeaturesFormat5Choice.Proprietary),nameof(OptionFeaturesFormat5Choice.Proprietary))]
    [IsoId("_e12wYd3eEd-KAqAOGQOnnw")]
    [DisplayName("Option Features Format 5 Choice")]
    public abstract partial record OptionFeaturesFormat5Choice_
    {
    }
}
