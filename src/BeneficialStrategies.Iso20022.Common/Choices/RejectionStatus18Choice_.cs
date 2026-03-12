// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus18Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus18Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus18Choice.NoSpecifiedReason),nameof(RejectionStatus18Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus18Choice.Reason),nameof(RejectionStatus18Choice.Reason))]
    [IsoId("_QpvlATq2EeWyoP0PbocV1Q")]
    [DisplayName("Rejection Status 18 Choice")]
    public abstract partial record RejectionStatus18Choice_
    {
    }
}
