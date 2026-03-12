// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat22Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat22Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionFeaturesFormat22Choice.Code),nameof(OptionFeaturesFormat22Choice.Code))]
    [JsonDerivedType(typeof(OptionFeaturesFormat22Choice.Proprietary),nameof(OptionFeaturesFormat22Choice.Proprietary))]
    [IsoId("_c25jIYcmEeavwKddCbm3hg")]
    [DisplayName("Option Features Format 22 Choice")]
    public abstract partial record OptionFeaturesFormat22Choice_
    {
    }
}
