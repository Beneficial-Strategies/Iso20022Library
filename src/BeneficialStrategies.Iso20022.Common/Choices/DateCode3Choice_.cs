// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode3Choice.Code))]
    [KnownType(typeof(DateCode3Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode3Choice.Code), nameof(DateCode3Choice.Code))]
    [JsonDerivedType(typeof(DateCode3Choice.Proprietary), nameof(DateCode3Choice.Proprietary))]
    [IsoId("_Q48_SNp-Ed-ak6NoX_4Aeg_1411669579")]
    [DisplayName("Date Code 3 Choice")]
    public abstract record DateCode3Choice_ { }
}
