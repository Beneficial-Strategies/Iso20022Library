// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat22Choice.Date))]
    [KnownType(typeof(DateFormat22Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat22Choice.Date),nameof(DateFormat22Choice.Date))]
    [JsonDerivedType(typeof(DateFormat22Choice.DateCode),nameof(DateFormat22Choice.DateCode))]
    [IsoId("_EzvTUggYEeCVlvYcV4HKqQ")]
    [DisplayName("Date Format 22 Choice")]
    public abstract partial record DateFormat22Choice_
    {
    }
}
