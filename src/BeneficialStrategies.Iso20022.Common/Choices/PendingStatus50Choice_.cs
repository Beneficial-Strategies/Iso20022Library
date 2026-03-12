// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus50Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus50Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus50Choice.NoSpecifiedReason),nameof(PendingStatus50Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus50Choice.Reason),nameof(PendingStatus50Choice.Reason))]
    [IsoId("_6QBP3ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Status 50 Choice")]
    public abstract partial record PendingStatus50Choice_
    {
    }
}
