// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BeneficialStrategies.Iso20022.Choices.PendingCancellationReason9Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a standard code or a proprietary code to specify the reason why a cancellation request sent for the related instruction is pending.</summary>
    [IsoId("_ddqCdd8QEe-NrtAAlrBEgQ")]
    [DisplayName("Pending Cancellation Reason 9 Choice")]
    [KnownType(typeof(Code))]
    [KnownType(typeof(Proprietary))]
    [JsonDerivedType(typeof(Code))]
    [JsonDerivedType(typeof(Proprietary))]
    public abstract record PendingCancellationReason9Choice_;
}
