// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying to the instruction cancellation request received.
    /// </summary>
    [KnownType(typeof(CancellationStatus2Choice.ProcessingStatus))]
    [KnownType(typeof(CancellationStatus2Choice.RejectionStatus))]
    [JsonDerivedType(typeof(CancellationStatus2Choice.ProcessingStatus),nameof(CancellationStatus2Choice.ProcessingStatus))]
    [JsonDerivedType(typeof(CancellationStatus2Choice.RejectionStatus),nameof(CancellationStatus2Choice.RejectionStatus))]
    [IsoId("_RCy3wNp-Ed-ak6NoX_4Aeg_-815488240")]
    [DisplayName("Cancellation Status 2 Choice")]
    public abstract partial record CancellationStatus2Choice_
    {
    }
}
