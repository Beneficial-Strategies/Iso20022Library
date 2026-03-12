// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to specify the type of option event.
    /// </summary>
    [KnownType(typeof(OptionEventType1Choice.Code))]
    [KnownType(typeof(OptionEventType1Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionEventType1Choice.Code),nameof(OptionEventType1Choice.Code))]
    [JsonDerivedType(typeof(OptionEventType1Choice.Proprietary),nameof(OptionEventType1Choice.Proprietary))]
    [IsoId("_8K8KkJR0Eeeymf3kpbtgrA")]
    [DisplayName("Option Event Type 1 Choice")]
    public abstract partial record OptionEventType1Choice_
    {
    }
}
