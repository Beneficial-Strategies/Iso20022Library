// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Option Features Format31Choice.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat31Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat31Choice.Proprietary))]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat31Choice.Code),
        nameof(OptionFeaturesFormat31Choice.Code)
    )]
    [JsonDerivedType(
        typeof(OptionFeaturesFormat31Choice.Proprietary),
        nameof(OptionFeaturesFormat31Choice.Proprietary)
    )]
    [IsoId("_U1QSfXSdEe6VWZz2tTgENw")]
    [DisplayName("Option Features Format31Choice")]
    public abstract record OptionFeaturesFormat31Choice_ { }
}
