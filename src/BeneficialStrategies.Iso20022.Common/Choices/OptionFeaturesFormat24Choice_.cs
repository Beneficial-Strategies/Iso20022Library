// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat24Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat24Choice.Proprietary))]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat24Choice.Code),
        nameof(OptionFeaturesFormat24Choice.Code)
    )]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat24Choice.Proprietary),
        nameof(OptionFeaturesFormat24Choice.Proprietary)
    )]
    [IsoId("_WCfX0baCEeiN--kDwanlkA")]
    [DisplayName("Option Features Format 24 Choice")]
    public abstract record OptionFeaturesFormat24Choice_ { }
}
