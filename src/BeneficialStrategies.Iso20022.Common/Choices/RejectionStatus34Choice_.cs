// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction has been rejected for further processing.
    /// </summary>
    [KnownType(typeof(RejectionStatus34Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus34Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionStatus34Choice.NoSpecifiedReason),
        nameof(RejectionStatus34Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionStatus34Choice.Reason),
        nameof(RejectionStatus34Choice.Reason)
    )]
    [IsoId("_T_zx8RIwEeydmIVkS03esw")]
    [DisplayName("Rejection Status 34 Choice")]
    public abstract record RejectionStatus34Choice_ { }
}
