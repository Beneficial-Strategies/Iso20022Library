// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode33Choice.Code))]
    [KnownType(typeof(DateCode33Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode33Choice.Code), nameof(DateCode33Choice.Code))]
    [JsonDerivedType(typeof(DateCode33Choice.Proprietary), nameof(DateCode33Choice.Proprietary))]
    [IsoId("_d28mCu3DEeqc-LCjwLsUVg")]
    [DisplayName("Date Code 33 Choice")]
    public abstract record DateCode33Choice_ { }
}
