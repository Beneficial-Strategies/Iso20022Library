// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the priority.
    /// </summary>
    [KnownType(typeof(PriorityNumeric4Choice.Numeric))]
    [KnownType(typeof(PriorityNumeric4Choice.Proprietary))]
    [JsonDerivedType(typeof(PriorityNumeric4Choice.Numeric),nameof(PriorityNumeric4Choice.Numeric))]
    [JsonDerivedType(typeof(PriorityNumeric4Choice.Proprietary),nameof(PriorityNumeric4Choice.Proprietary))]
    [IsoId("_rhERsTtDEeWRTLSN0i0tng")]
    [DisplayName("Priority Numeric 4 Choice")]
    public abstract partial record PriorityNumeric4Choice_
    {
    }
}
