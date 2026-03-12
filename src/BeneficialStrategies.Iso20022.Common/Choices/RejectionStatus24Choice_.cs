// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus24Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus24Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus24Choice.NoSpecifiedReason),nameof(RejectionStatus24Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus24Choice.Reason),nameof(RejectionStatus24Choice.Reason))]
    [IsoId("_6QDEhZNLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Status 24 Choice")]
    public abstract partial record RejectionStatus24Choice_
    {
    }
}
