// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the option style.
    /// </summary>
    [KnownType(typeof(OptionStyle6Choice.Code))]
    [KnownType(typeof(OptionStyle6Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionStyle6Choice.Code),nameof(OptionStyle6Choice.Code))]
    [JsonDerivedType(typeof(OptionStyle6Choice.Proprietary),nameof(OptionStyle6Choice.Proprietary))]
    [IsoId("_AbgFtdokEeC60axPepSq7g_2026948827")]
    [DisplayName("Option Style 6 Choice")]
    public abstract partial record OptionStyle6Choice_
    {
    }
}
