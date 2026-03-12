// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction has been rejected for further processing.
    /// </summary>
    [KnownType(typeof(RejectionStatus33Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus33Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus33Choice.NoSpecifiedReason),nameof(RejectionStatus33Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus33Choice.Reason),nameof(RejectionStatus33Choice.Reason))]
    [IsoId("_FjyNTxIwEeydmIVkS03esw")]
    [DisplayName("Rejection Status 33 Choice")]
    public abstract partial record RejectionStatus33Choice_
    {
    }
}
