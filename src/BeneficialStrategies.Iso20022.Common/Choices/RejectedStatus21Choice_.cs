// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus21Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus21Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus21Choice.NoSpecifiedReason),nameof(RejectedStatus21Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus21Choice.Reason),nameof(RejectedStatus21Choice.Reason))]
    [IsoId("_cgn4Q5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rejected Status 21 Choice")]
    public abstract partial record RejectedStatus21Choice_
    {
    }
}
