// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [KnownType(typeof(CancellationReason2Choice.Code))]
    [KnownType(typeof(CancellationReason2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationReason2Choice.Code),
        nameof(CancellationReason2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationReason2Choice.Proprietary),
        nameof(CancellationReason2Choice.Proprietary)
    )]
    [IsoId("_TPmtldp-Ed-ak6NoX_4Aeg_-617774540")]
    [DisplayName("Cancellation Reason 2 Choice")]
    public abstract record CancellationReason2Choice_ { }
}
