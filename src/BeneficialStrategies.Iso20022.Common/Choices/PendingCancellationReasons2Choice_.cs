// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending cancellation reason.
    /// </summary>
    [KnownType(typeof(PendingCancellationReasons2Choice.Code))]
    [KnownType(typeof(PendingCancellationReasons2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PendingCancellationReasons2Choice.Code),
        nameof(PendingCancellationReasons2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PendingCancellationReasons2Choice.Proprietary),
        nameof(PendingCancellationReasons2Choice.Proprietary)
    )]
    [IsoId("_UYBuNtp-Ed-ak6NoX_4Aeg_-1094614549")]
    [DisplayName("Pending Cancellation Reasons 2 Choice")]
    public abstract record PendingCancellationReasons2Choice_ { }
}
