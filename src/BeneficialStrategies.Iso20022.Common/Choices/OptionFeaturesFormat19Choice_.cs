// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat19Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat19Choice.Proprietary))]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat19Choice.Code),
        nameof(OptionFeaturesFormat19Choice.Code)
    )]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat19Choice.Proprietary),
        nameof(OptionFeaturesFormat19Choice.Proprietary)
    )]
    [IsoId("_cj7rK5KQEeWHWpTQn1FFVg")]
    [DisplayName("Option Features Format 19 Choice")]
    public abstract record OptionFeaturesFormat19Choice_ { }
}
