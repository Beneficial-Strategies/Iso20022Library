// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode11Choice.Code))]
    [KnownType(typeof(DateCode11Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode11Choice.Code), nameof(DateCode11Choice.Code))]
    [JsonDerivedType(typeof(DateCode11Choice.Proprietary), nameof(DateCode11Choice.Proprietary))]
    [IsoId("_lHtQUfZFEd-2Jsl2KtUQCw")]
    [DisplayName("Date Code 11 Choice")]
    public abstract record DateCode11Choice_ { }
}
