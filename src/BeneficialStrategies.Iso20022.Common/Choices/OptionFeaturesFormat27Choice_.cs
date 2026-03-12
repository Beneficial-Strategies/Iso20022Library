// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat27Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat27Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionFeaturesFormat27Choice.Code),nameof(OptionFeaturesFormat27Choice.Code))]
    [JsonDerivedType(typeof(OptionFeaturesFormat27Choice.Proprietary),nameof(OptionFeaturesFormat27Choice.Proprietary))]
    [IsoId("_732uofyYEeiKOe8GCUL1Lg")]
    [DisplayName("Option Features Format 27 Choice")]
    public abstract partial record OptionFeaturesFormat27Choice_
    {
    }
}
