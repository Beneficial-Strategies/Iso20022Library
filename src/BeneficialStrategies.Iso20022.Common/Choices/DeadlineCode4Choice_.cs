// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a deadline code.
    /// </summary>
    [KnownType(typeof(DeadlineCode4Choice.Code))]
    [KnownType(typeof(DeadlineCode4Choice.Proprietary))]
    [JsonDerivedType(typeof(DeadlineCode4Choice.Code), nameof(DeadlineCode4Choice.Code))]
    [JsonDerivedType(
        typeof(DeadlineCode4Choice.Proprietary),
        nameof(DeadlineCode4Choice.Proprietary)
    )]
    [IsoId("_cfssk5KQEeWHWpTQn1FFVg")]
    [DisplayName("Deadline Code 4 Choice")]
    public abstract record DeadlineCode4Choice_ { }
}
