// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the date.
    /// </summary>
    [KnownType(typeof(DateCode32Choice.Code))]
    [KnownType(typeof(DateCode32Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode32Choice.Code),nameof(DateCode32Choice.Code))]
    [JsonDerivedType(typeof(DateCode32Choice.Proprietary),nameof(DateCode32Choice.Proprietary))]
    [IsoId("_5mw3u5NLEeWGlc8L7oPDIg")]
    [DisplayName("Date Code 32 Choice")]
    public abstract partial record DateCode32Choice_
    {
    }
}
