// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode4Choice.Code))]
    [KnownType(typeof(DateCode4Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode4Choice.Code), nameof(DateCode4Choice.Code))]
    [JsonDerivedType(typeof(DateCode4Choice.Proprietary), nameof(DateCode4Choice.Proprietary))]
    [IsoId("_Q2uKpdp-Ed-ak6NoX_4Aeg_398585783")]
    [DisplayName("Date Code 4 Choice")]
    public abstract record DateCode4Choice_ { }
}
