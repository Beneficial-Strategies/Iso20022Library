// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancelledStatus16Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus16Choice.Reason))]
    [JsonDerivedType(
        typeof(CancelledStatus16Choice.NoSpecifiedReason),
        nameof(CancelledStatus16Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(CancelledStatus16Choice.Reason),
        nameof(CancelledStatus16Choice.Reason)
    )]
    [IsoId("_6HWbW5NLEeWGlc8L7oPDIg")]
    [DisplayName("Cancelled Status 16 Choice")]
    public abstract record CancelledStatus16Choice_ { }
}
