// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for a cancelled reason.
    /// </summary>
    [KnownType(typeof(CancelledReason12Choice.Code))]
    [KnownType(typeof(CancelledReason12Choice.Proprietary))]
    [KnownType(typeof(CancelledReason12Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancelledReason12Choice.Code), nameof(CancelledReason12Choice.Code))]
    [JsonDerivedType(
        typeof(CancelledReason12Choice.Proprietary),
        nameof(CancelledReason12Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(CancelledReason12Choice.NoSpecifiedReason),
        nameof(CancelledReason12Choice.NoSpecifiedReason)
    )]
    [IsoId("_eoqj8UHTEeasdbKMiqizqA")]
    [DisplayName("Cancelled Reason 12 Choice")]
    public abstract record CancelledReason12Choice_ { }
}
