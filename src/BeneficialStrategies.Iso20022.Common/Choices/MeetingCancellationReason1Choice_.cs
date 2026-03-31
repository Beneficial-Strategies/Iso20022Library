// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of meeting cancellation reason.
    /// </summary>
    [KnownType(typeof(MeetingCancellationReason1Choice.Code))]
    [KnownType(typeof(MeetingCancellationReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(MeetingCancellationReason1Choice.Code),
        nameof(MeetingCancellationReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(MeetingCancellationReason1Choice.Proprietary),
        nameof(MeetingCancellationReason1Choice.Proprietary)
    )]
    [IsoId("_RCWL0dp-Ed-ak6NoX_4Aeg_1417276542")]
    [DisplayName("Meeting Cancellation Reason 1 Choice")]
    public abstract record MeetingCancellationReason1Choice_ { }
}
