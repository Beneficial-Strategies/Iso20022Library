// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for option type.
    /// </summary>
    [KnownType(typeof(OptionType8Choice.Code))]
    [KnownType(typeof(OptionType8Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionType8Choice.Code), nameof(OptionType8Choice.Code))]
    [JsonDerivedType(typeof(OptionType8Choice.Proprietary), nameof(OptionType8Choice.Proprietary))]
    [IsoId("_xoFSIeLaEeWFtOV72FbX9w")]
    [DisplayName("Option Type 8 Choice")]
    public abstract record OptionType8Choice_ { }
}
