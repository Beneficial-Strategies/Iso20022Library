// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat25Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat25Choice.Proprietary))]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat25Choice.Code),
        nameof(OptionFeaturesFormat25Choice.Code)
    )]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat25Choice.Proprietary),
        nameof(OptionFeaturesFormat25Choice.Proprietary)
    )]
    [IsoId("_r_Y5tLaSEeiN--kDwanlkA")]
    [DisplayName("Option Features Format 25 Choice")]
    public abstract record OptionFeaturesFormat25Choice_ { }
}
