// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectedStatus22Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus22Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus22Choice.NoSpecifiedReason),nameof(RejectedStatus22Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus22Choice.Reason),nameof(RejectedStatus22Choice.Reason))]
    [IsoId("_6HV1B5NLEeWGlc8L7oPDIg")]
    [DisplayName("Rejected Status 22 Choice")]
    public abstract partial record RejectedStatus22Choice_
    {
    }
}
