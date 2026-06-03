// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RejectedStatus62Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between no specified reason and a reason for rejected status.</summary>
    [IsoId("_jxvsEd8PEe-NrtAAlrBEgQ")]
    [DisplayName("Rejected Status 62 Choice")]
    [KnownType(typeof(RejectedStatus62Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus62Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus62Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus62Choice.Reason))]
    public abstract record RejectedStatus62Choice_
    {
    }
}
