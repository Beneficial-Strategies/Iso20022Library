// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode27Choice.Code))]
    [KnownType(typeof(DateCode27Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode27Choice.Code), nameof(DateCode27Choice.Code))]
    [JsonDerivedType(typeof(DateCode27Choice.Proprietary), nameof(DateCode27Choice.Proprietary))]
    [IsoId("_ctmkPZKQEeWHWpTQn1FFVg")]
    [DisplayName("Date Code 27 Choice")]
    public abstract record DateCode27Choice_ { }
}
