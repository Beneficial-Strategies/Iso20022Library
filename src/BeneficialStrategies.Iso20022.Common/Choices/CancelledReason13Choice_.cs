// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Cancelled Reason13Choice.
    /// </summary>
    [KnownType(typeof(CancelledReason13Choice.Code))]
    [KnownType(typeof(CancelledReason13Choice.Proprietary))]
    [JsonDerivedType(typeof(CancelledReason13Choice.Code), nameof(CancelledReason13Choice.Code))]
    [JsonDerivedType(
        typeof(CancelledReason13Choice.Proprietary),
        nameof(CancelledReason13Choice.Proprietary)
    )]
    [IsoId("_ucE0gZznEe-DHYbvdRjdbA")]
    [DisplayName("Cancelled Reason13Choice")]
    public abstract record CancelledReason13Choice_ { }
}
