// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the option style.
    /// </summary>
    [KnownType(typeof(OptionStyle9Choice.Code))]
    [KnownType(typeof(OptionStyle9Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionStyle9Choice.Code), nameof(OptionStyle9Choice.Code))]
    [JsonDerivedType(
        typeof(OptionStyle9Choice.Proprietary),
        nameof(OptionStyle9Choice.Proprietary)
    )]
    [IsoId("_ctPX95KQEeWHWpTQn1FFVg")]
    [DisplayName("Option Style 9 Choice")]
    public abstract record OptionStyle9Choice_ { }
}
