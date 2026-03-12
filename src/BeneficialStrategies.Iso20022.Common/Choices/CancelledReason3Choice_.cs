// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request is cancelled.
    /// </summary>
    [KnownType(typeof(CancelledReason3Choice.Code))]
    [KnownType(typeof(CancelledReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(CancelledReason3Choice.Code),nameof(CancelledReason3Choice.Code))]
    [JsonDerivedType(typeof(CancelledReason3Choice.Proprietary),nameof(CancelledReason3Choice.Proprietary))]
    [IsoId("_YlglkeJxEd-Q6MzBzY5WkA")]
    [DisplayName("Cancelled Reason 3 Choice")]
    public abstract partial record CancelledReason3Choice_
    {
    }
}
