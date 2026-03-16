// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat9Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat9Choice.Proprietary))]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat9Choice.Code),
        nameof(OptionFeaturesFormat9Choice.Code)
    )]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat9Choice.Proprietary),
        nameof(OptionFeaturesFormat9Choice.Proprietary)
    )]
    [IsoId("_z-bBsfonEeCM181g5EbUXw")]
    [DisplayName("Option Features Format 9 Choice")]
    public abstract record OptionFeaturesFormat9Choice_ { }
}
