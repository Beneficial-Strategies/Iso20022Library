// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request is cancelled.
    /// </summary>
    [KnownType(typeof(CancelledReason5Choice.Code))]
    [KnownType(typeof(CancelledReason5Choice.Proprietary))]
    [JsonDerivedType(typeof(CancelledReason5Choice.Code),nameof(CancelledReason5Choice.Code))]
    [JsonDerivedType(typeof(CancelledReason5Choice.Proprietary),nameof(CancelledReason5Choice.Proprietary))]
    [IsoId("_dHW15VhlEeSsH9MSoogb7Q")]
    [DisplayName("Cancelled Reason 5 Choice")]
    public abstract partial record CancelledReason5Choice_
    {
    }
}
