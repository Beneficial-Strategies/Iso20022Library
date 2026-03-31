// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the option style.
    /// </summary>
    [KnownType(typeof(OptionStyle10Choice.Code))]
    [KnownType(typeof(OptionStyle10Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionStyle10Choice.Code), nameof(OptionStyle10Choice.Code))]
    [JsonDerivedType(
        typeof(OptionStyle10Choice.Proprietary),
        nameof(OptionStyle10Choice.Proprietary)
    )]
    [IsoId("_zrGR8ZBhEeakHoV5BVecAQ")]
    [DisplayName("Option Style 10 Choice")]
    public abstract record OptionStyle10Choice_ { }
}
