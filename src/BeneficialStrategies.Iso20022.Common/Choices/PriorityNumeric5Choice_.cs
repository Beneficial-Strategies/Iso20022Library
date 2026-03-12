// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the priority.
    /// </summary>
    [KnownType(typeof(PriorityNumeric5Choice.Numeric))]
    [KnownType(typeof(PriorityNumeric5Choice.Proprietary))]
    [JsonDerivedType(typeof(PriorityNumeric5Choice.Numeric),nameof(PriorityNumeric5Choice.Numeric))]
    [JsonDerivedType(typeof(PriorityNumeric5Choice.Proprietary),nameof(PriorityNumeric5Choice.Proprietary))]
    [IsoId("_5Pg0WJNLEeWGlc8L7oPDIg")]
    [DisplayName("Priority Numeric 5 Choice")]
    public abstract partial record PriorityNumeric5Choice_
    {
    }
}
