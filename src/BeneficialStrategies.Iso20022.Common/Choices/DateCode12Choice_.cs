// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode12Choice.Code))]
    [KnownType(typeof(DateCode12Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode12Choice.Code),nameof(DateCode12Choice.Code))]
    [JsonDerivedType(typeof(DateCode12Choice.Proprietary),nameof(DateCode12Choice.Proprietary))]
    [IsoId("_EzliWwgYEeCVlvYcV4HKqQ")]
    [DisplayName("Date Code 12 Choice")]
    public abstract partial record DateCode12Choice_
    {
    }
}
