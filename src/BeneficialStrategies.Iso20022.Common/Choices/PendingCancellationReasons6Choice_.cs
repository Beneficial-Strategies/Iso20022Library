// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingCancellationReasons6Choice;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the pending cancellation reason.</summary>
    [IsoId("_2YhbgaoWEfCG2_q2WT-90w")]
    [DisplayName("Pending Cancellation Reasons 6 Choice")]
    [KnownType(typeof(Code))]
    [KnownType(typeof(Proprietary))]
    [JsonDerivedType(typeof(Code))]
    [JsonDerivedType(typeof(Proprietary))]
    public abstract record PendingCancellationReasons6Choice_;
}
