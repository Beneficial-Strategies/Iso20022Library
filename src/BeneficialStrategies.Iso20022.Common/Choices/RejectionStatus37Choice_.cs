// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus37Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus37Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus37Choice.NoSpecifiedReason),nameof(RejectionStatus37Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus37Choice.Reason),nameof(RejectionStatus37Choice.Reason))]
    [IsoId("_OqjeNytWEeyhipY4f42fZQ")]
    [DisplayName("Rejection Status 37 Choice")]
    public abstract partial record RejectionStatus37Choice_
    {
    }
}
