// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus40Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus40Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus40Choice.NoSpecifiedReason),nameof(PendingStatus40Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus40Choice.Reason),nameof(PendingStatus40Choice.Reason))]
    [IsoId("_pnOLkTw9EeW3QqUkIQtIUA")]
    [DisplayName("Pending Status 40 Choice")]
    public abstract partial record PendingStatus40Choice_
    {
    }
}
