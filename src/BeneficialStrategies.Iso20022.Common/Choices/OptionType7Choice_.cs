// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the option type.
    /// </summary>
    [KnownType(typeof(OptionType7Choice.Code))]
    [KnownType(typeof(OptionType7Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionType7Choice.Code),nameof(OptionType7Choice.Code))]
    [JsonDerivedType(typeof(OptionType7Choice.Proprietary),nameof(OptionType7Choice.Proprietary))]
    [IsoId("_5NaizZNLEeWGlc8L7oPDIg")]
    [DisplayName("Option Type 7 Choice")]
    public abstract partial record OptionType7Choice_
    {
    }
}
