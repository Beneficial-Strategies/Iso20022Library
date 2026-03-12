// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of rejection status.
    /// </summary>
    [KnownType(typeof(RejectionStatus20Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus20Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus20Choice.NoSpecifiedReason),nameof(RejectionStatus20Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus20Choice.Reason),nameof(RejectionStatus20Choice.Reason))]
    [IsoId("_mdrUlzzpEeWeNtT0s2RbkQ")]
    [DisplayName("Rejection Status 20 Choice")]
    public abstract partial record RejectionStatus20Choice_
    {
    }
}
