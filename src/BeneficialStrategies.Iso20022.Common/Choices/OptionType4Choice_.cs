// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the option type.
    /// </summary>
    [KnownType(typeof(OptionType4Choice.Code))]
    [KnownType(typeof(OptionType4Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionType4Choice.Code), nameof(OptionType4Choice.Code))]
    [JsonDerivedType(typeof(OptionType4Choice.Proprietary), nameof(OptionType4Choice.Proprietary))]
    [IsoId("_AbgFstokEeC60axPepSq7g_934276367")]
    [DisplayName("Option Type 4 Choice")]
    public abstract record OptionType4Choice_ { }
}
