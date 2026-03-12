// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode22Choice.Code))]
    [KnownType(typeof(DateCode22Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode22Choice.Code),nameof(DateCode22Choice.Code))]
    [JsonDerivedType(typeof(DateCode22Choice.Proprietary),nameof(DateCode22Choice.Proprietary))]
    [IsoId("_cdSQd5KQEeWHWpTQn1FFVg")]
    [DisplayName("Date Code 22 Choice")]
    public abstract partial record DateCode22Choice_
    {
    }
}
