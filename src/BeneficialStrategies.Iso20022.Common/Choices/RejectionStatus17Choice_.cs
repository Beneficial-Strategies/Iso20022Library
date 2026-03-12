// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus17Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus17Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus17Choice.NoSpecifiedReason),nameof(RejectionStatus17Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus17Choice.Reason),nameof(RejectionStatus17Choice.Reason))]
    [IsoId("_qwoVsTqzEeWyoP0PbocV1Q")]
    [DisplayName("Rejection Status 17 Choice")]
    public abstract partial record RejectionStatus17Choice_
    {
    }
}
