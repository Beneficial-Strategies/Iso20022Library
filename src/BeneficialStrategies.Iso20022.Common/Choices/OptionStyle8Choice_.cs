// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the option style.
    /// </summary>
    [KnownType(typeof(OptionStyle8Choice.Code))]
    [KnownType(typeof(OptionStyle8Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionStyle8Choice.Code),nameof(OptionStyle8Choice.Code))]
    [JsonDerivedType(typeof(OptionStyle8Choice.Proprietary),nameof(OptionStyle8Choice.Proprietary))]
    [IsoId("_g3ipUTq2EeWQ1Y7f8kds2A")]
    [DisplayName("Option Style 8 Choice")]
    public abstract partial record OptionStyle8Choice_
    {
    }
}
