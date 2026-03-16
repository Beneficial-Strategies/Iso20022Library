// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between elements to define a time period.
    /// </summary>
    [KnownType(typeof(TimeFrame8Choice.TradePlus))]
    [KnownType(typeof(TimeFrame8Choice.RenunciationPlus))]
    [JsonDerivedType(typeof(TimeFrame8Choice.TradePlus), nameof(TimeFrame8Choice.TradePlus))]
    [JsonDerivedType(
        typeof(TimeFrame8Choice.RenunciationPlus),
        nameof(TimeFrame8Choice.RenunciationPlus)
    )]
    [IsoId("_bxgQATgFEei6RvewLQWEqw")]
    [DisplayName("Time Frame 8 Choice")]
    public abstract record TimeFrame8Choice_ { }
}
