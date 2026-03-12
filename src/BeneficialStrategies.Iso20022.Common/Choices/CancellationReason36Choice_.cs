// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason36Choice.Code))]
    [KnownType(typeof(CancellationReason36Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason36Choice.Code),nameof(CancellationReason36Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason36Choice.Proprietary),nameof(CancellationReason36Choice.Proprietary))]
    [IsoId("_HkfY8dB7EeihG9bKfarOOA")]
    [DisplayName("Cancellation Reason 36 Choice")]
    public abstract partial record CancellationReason36Choice_
    {
    }
}
