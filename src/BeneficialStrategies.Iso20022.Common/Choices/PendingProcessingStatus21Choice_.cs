// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus21Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies whether the status is provided with a reason or not.</summary>
    [IsoId("3b0ae95e-06ce-424b-b13f-e1aa0fb0e0f4")]
    [DisplayName("Pending Processing Status 21 Choice")]
    [KnownType(typeof(PendingProcessingStatus21Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus21Choice.Reason))]
    [JsonDerivedType(typeof(PendingProcessingStatus21Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingProcessingStatus21Choice.Reason))]
    public abstract record PendingProcessingStatus21Choice_
    {
    }
}
