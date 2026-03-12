// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus19Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus19Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus19Choice.NoSpecifiedReason),nameof(RejectionStatus19Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus19Choice.Reason),nameof(RejectionStatus19Choice.Reason))]
    [IsoId("_beLxITw5EeW3QqUkIQtIUA")]
    [DisplayName("Rejection Status 19 Choice")]
    public abstract partial record RejectionStatus19Choice_
    {
    }
}
