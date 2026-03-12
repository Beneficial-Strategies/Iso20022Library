// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode34Choice.Code))]
    [KnownType(typeof(DateCode34Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode34Choice.Code),nameof(DateCode34Choice.Code))]
    [JsonDerivedType(typeof(DateCode34Choice.Proprietary),nameof(DateCode34Choice.Proprietary))]
    [IsoId("_nnWVcTUIEe2tRf29bleifQ")]
    [DisplayName("Date Code 34 Choice")]
    public abstract partial record DateCode34Choice_
    {
    }
}
