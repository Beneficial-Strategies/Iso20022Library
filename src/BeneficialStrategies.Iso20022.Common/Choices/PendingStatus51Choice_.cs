// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus51Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus51Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus51Choice.NoSpecifiedReason),nameof(PendingStatus51Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus51Choice.Reason),nameof(PendingStatus51Choice.Reason))]
    [IsoId("_6QDsBZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Status 51 Choice")]
    public abstract partial record PendingStatus51Choice_
    {
    }
}
