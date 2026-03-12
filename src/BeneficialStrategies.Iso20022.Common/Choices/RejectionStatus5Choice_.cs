// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus5Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus5Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus5Choice.NoSpecifiedReason),nameof(RejectionStatus5Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus5Choice.Reason),nameof(RejectionStatus5Choice.Reason))]
    [IsoId("__qYfe_4wEeClUvPNHKL9Zw")]
    [DisplayName("Rejection Status 5 Choice")]
    public abstract partial record RejectionStatus5Choice_
    {
    }
}
