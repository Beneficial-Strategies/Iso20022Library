// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the priority.
    /// </summary>
    [KnownType(typeof(PriorityNumeric3Choice.Numeric))]
    [KnownType(typeof(PriorityNumeric3Choice.Proprietary))]
    [JsonDerivedType(typeof(PriorityNumeric3Choice.Numeric),nameof(PriorityNumeric3Choice.Numeric))]
    [JsonDerivedType(typeof(PriorityNumeric3Choice.Proprietary),nameof(PriorityNumeric3Choice.Proprietary))]
    [IsoId("_AbMjtdokEeC60axPepSq7g_-1361106617")]
    [DisplayName("Priority Numeric 3 Choice")]
    public abstract partial record PriorityNumeric3Choice_
    {
    }
}
