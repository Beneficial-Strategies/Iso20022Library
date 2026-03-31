// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode9Choice.Code))]
    [KnownType(typeof(DateCode9Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode9Choice.Code), nameof(DateCode9Choice.Code))]
    [JsonDerivedType(typeof(DateCode9Choice.Proprietary), nameof(DateCode9Choice.Proprietary))]
    [IsoId("_Qm7bKNp-Ed-ak6NoX_4Aeg_-370224609")]
    [DisplayName("Date Code 9 Choice")]
    public abstract record DateCode9Choice_ { }
}
