// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingProcessingReason20Choice;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the pending processing reason.</summary>
    [IsoId("75a6e078-5fd3-497f-8bb8-96a1032c109f")]
    [DisplayName("Pending Processing Reason 20 Choice")]
    [KnownType(typeof(Code))]
    [KnownType(typeof(Proprietary))]
    [JsonDerivedType(typeof(Code))]
    [JsonDerivedType(typeof(Proprietary))]
    public abstract record PendingProcessingReason20Choice_;
}
