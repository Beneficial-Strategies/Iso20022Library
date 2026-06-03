// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingProcessingReason22Choice;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the pending processing reason.</summary>
    [IsoId("_reFtQaohEfCG2_q2WT-90w")]
    [DisplayName("Pending Processing Reason 22 Choice")]
    [KnownType(typeof(Code))]
    [KnownType(typeof(Proprietary))]
    [JsonDerivedType(typeof(Code))]
    [JsonDerivedType(typeof(Proprietary))]
    public abstract record PendingProcessingReason22Choice_;
}
