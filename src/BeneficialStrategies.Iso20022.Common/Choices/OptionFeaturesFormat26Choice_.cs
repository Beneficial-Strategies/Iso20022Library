// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat26Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat26Choice.Proprietary))]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat26Choice.Code),
        nameof(OptionFeaturesFormat26Choice.Code)
    )]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat26Choice.Proprietary),
        nameof(OptionFeaturesFormat26Choice.Proprietary)
    )]
    [IsoId("_cs42v_fSEeiNZp_PtLohLw")]
    [DisplayName("Option Features Format 26 Choice")]
    public abstract record OptionFeaturesFormat26Choice_ { }
}
