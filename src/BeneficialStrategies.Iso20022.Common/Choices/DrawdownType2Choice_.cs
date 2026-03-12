// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of drawdown.
    /// </summary>
    [KnownType(typeof(DrawdownType2Choice.Code))]
    [KnownType(typeof(DrawdownType2Choice.Proprietary))]
    [JsonDerivedType(typeof(DrawdownType2Choice.Code),nameof(DrawdownType2Choice.Code))]
    [JsonDerivedType(typeof(DrawdownType2Choice.Proprietary),nameof(DrawdownType2Choice.Proprietary))]
    [IsoId("_mnrMcZNwEembCsVG-3f_AA")]
    [DisplayName("Drawdown Type 2 Choice")]
    public abstract partial record DrawdownType2Choice_
    {
    }
}
