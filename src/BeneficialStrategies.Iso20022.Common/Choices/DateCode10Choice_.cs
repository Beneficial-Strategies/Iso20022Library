// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode10Choice.Code))]
    [KnownType(typeof(DateCode10Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode10Choice.Code),nameof(DateCode10Choice.Code))]
    [JsonDerivedType(typeof(DateCode10Choice.Proprietary),nameof(DateCode10Choice.Proprietary))]
    [IsoId("_Ezm-IeENEd-qUMZtd_eZuQ")]
    [DisplayName("Date Code 10 Choice")]
    public abstract partial record DateCode10Choice_
    {
    }
}
