// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus38Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus38Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus38Choice.NoSpecifiedReason),nameof(RejectionStatus38Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus38Choice.Reason),nameof(RejectionStatus38Choice.Reason))]
    [IsoId("_rHpxEytWEeyhipY4f42fZQ")]
    [DisplayName("Rejection Status 38 Choice")]
    public abstract partial record RejectionStatus38Choice_
    {
    }
}
