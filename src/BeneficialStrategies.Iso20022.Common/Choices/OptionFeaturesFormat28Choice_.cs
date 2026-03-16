// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Option Features Format28Choice.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat28Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat28Choice.Proprietary))]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat28Choice.Code),
        nameof(OptionFeaturesFormat28Choice.Code)
    )]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat28Choice.Proprietary),
        nameof(OptionFeaturesFormat28Choice.Proprietary)
    )]
    [IsoId("_ta7E4WHHEe6yt_d72zQZeQ")]
    [DisplayName("Option Features Format28Choice")]
    public abstract record OptionFeaturesFormat28Choice_ { }
}
