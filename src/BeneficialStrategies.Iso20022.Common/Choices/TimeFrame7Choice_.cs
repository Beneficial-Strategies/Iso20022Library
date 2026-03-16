// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between elements to define a time period.
    /// </summary>
    [KnownType(typeof(TimeFrame7Choice.TradePlus))]
    [KnownType(typeof(TimeFrame7Choice.Prepayment))]
    [JsonDerivedType(typeof(TimeFrame7Choice.TradePlus), nameof(TimeFrame7Choice.TradePlus))]
    [JsonDerivedType(typeof(TimeFrame7Choice.Prepayment), nameof(TimeFrame7Choice.Prepayment))]
    [IsoId("_5ufTETgDEei6RvewLQWEqw")]
    [DisplayName("Time Frame 7 Choice")]
    public abstract record TimeFrame7Choice_ { }
}
