// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancelledStatus5Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus5Choice.Reason))]
    [JsonDerivedType(
        typeof(CancelledStatus5Choice.NoSpecifiedReason),
        nameof(CancelledStatus5Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(CancelledStatus5Choice.Reason), nameof(CancelledStatus5Choice.Reason))]
    [IsoId("_yFY2QCzbEeOsiuMH68so7Q")]
    [DisplayName("Cancelled Status 5 Choice")]
    public abstract record CancelledStatus5Choice_ { }
}
