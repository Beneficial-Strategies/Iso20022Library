// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RejectionReason6Format2Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of formats to express the reason of a rejection of the notification advice.</summary>
    [IsoId("_9v0PoKUoEfCnE_wCEfCqTA")]
    [DisplayName("Rejection Reason 6 Format 2 Choice")]
    [KnownType(typeof(RejectionReason6Format2Choice.Code))]
    [KnownType(typeof(RejectionReason6Format2Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason6Format2Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason6Format2Choice.Proprietary))]
    public abstract record RejectionReason6Format2Choice_
    {
    }
}
