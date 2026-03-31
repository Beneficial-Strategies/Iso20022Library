// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat20Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat20Choice.Proprietary))]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat20Choice.Code),
        nameof(OptionFeaturesFormat20Choice.Code)
    )]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat20Choice.Proprietary),
        nameof(OptionFeaturesFormat20Choice.Proprietary)
    )]
    [IsoId("_cta9-5KQEeWHWpTQn1FFVg")]
    [DisplayName("Option Features Format 20 Choice")]
    public abstract record OptionFeaturesFormat20Choice_ { }
}
