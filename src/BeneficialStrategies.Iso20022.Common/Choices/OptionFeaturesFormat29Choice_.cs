// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Option Features Format29Choice.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat29Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat29Choice.Proprietary))]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat29Choice.Code),
        nameof(OptionFeaturesFormat29Choice.Code)
    )]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat29Choice.Proprietary),
        nameof(OptionFeaturesFormat29Choice.Proprietary)
    )]
    [IsoId("_9vkikWKMEe6iKbrXdnOlfA")]
    [DisplayName("Option Features Format29Choice")]
    public abstract record OptionFeaturesFormat29Choice_ { }
}
