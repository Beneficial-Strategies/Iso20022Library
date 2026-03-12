// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode26Choice.Code))]
    [KnownType(typeof(DateCode26Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode26Choice.Code),nameof(DateCode26Choice.Code))]
    [JsonDerivedType(typeof(DateCode26Choice.Proprietary),nameof(DateCode26Choice.Proprietary))]
    [IsoId("_ctczFZKQEeWHWpTQn1FFVg")]
    [DisplayName("Date Code 26 Choice")]
    public abstract partial record DateCode26Choice_
    {
    }
}
