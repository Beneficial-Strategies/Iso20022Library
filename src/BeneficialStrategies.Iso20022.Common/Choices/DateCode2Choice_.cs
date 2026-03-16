// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode2Choice.Code))]
    [KnownType(typeof(DateCode2Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode2Choice.Code), nameof(DateCode2Choice.Code))]
    [JsonDerivedType(typeof(DateCode2Choice.Proprietary), nameof(DateCode2Choice.Proprietary))]
    [IsoId("_Q5GwQdp-Ed-ak6NoX_4Aeg_-1808675973")]
    [DisplayName("Date Code 2 Choice")]
    public abstract record DateCode2Choice_ { }
}
