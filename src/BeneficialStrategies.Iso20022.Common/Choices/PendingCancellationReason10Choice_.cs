// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BeneficialStrategies.Iso20022.Choices.PendingCancellationReason10Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a standard code or a proprietary code to specify the reason why a cancellation request sent for the related instruction is pending.</summary>
    [IsoId("_hIBt0aLNEfCHi7w3_0pcpw")]
    [DisplayName("Pending Cancellation Reason 10 Choice")]
    [KnownType(typeof(Code))]
    [KnownType(typeof(Proprietary))]
    [JsonDerivedType(typeof(Code))]
    [JsonDerivedType(typeof(Proprietary))]
    public abstract record PendingCancellationReason10Choice_;
}
