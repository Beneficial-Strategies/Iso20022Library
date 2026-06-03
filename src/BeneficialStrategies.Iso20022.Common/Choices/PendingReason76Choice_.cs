// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingReason76Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.</summary>
    [IsoId("_2ewoYaKtEfCHi7w3_0pcpw")]
    [DisplayName("Pending Reason 76 Choice")]
    [KnownType(typeof(PendingReason76Choice.Code))]
    [KnownType(typeof(PendingReason76Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason76Choice.Code))]
    [JsonDerivedType(typeof(PendingReason76Choice.Proprietary))]
    public abstract record PendingReason76Choice_
    {
    }
}
