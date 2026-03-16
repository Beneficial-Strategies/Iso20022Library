// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for a partially settled reason.
    /// </summary>
    [KnownType(typeof(PartiallySettled21Choice.Code))]
    [KnownType(typeof(PartiallySettled21Choice.Proprietary))]
    [JsonDerivedType(typeof(PartiallySettled21Choice.Code), nameof(PartiallySettled21Choice.Code))]
    [JsonDerivedType(
        typeof(PartiallySettled21Choice.Proprietary),
        nameof(PartiallySettled21Choice.Proprietary)
    )]
    [IsoId("_R48xQUHtEeaNSo9he0Belg")]
    [DisplayName("Partially Settled 21 Choice")]
    public abstract record PartiallySettled21Choice_ { }
}
