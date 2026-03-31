// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the option type.
    /// </summary>
    [KnownType(typeof(OptionType6Choice.Code))]
    [KnownType(typeof(OptionType6Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionType6Choice.Code), nameof(OptionType6Choice.Code))]
    [JsonDerivedType(typeof(OptionType6Choice.Proprietary), nameof(OptionType6Choice.Proprietary))]
    [IsoId("_tfykITnCEeWV5sr121Fc8A")]
    [DisplayName("Option Type 6 Choice")]
    public abstract record OptionType6Choice_ { }
}
