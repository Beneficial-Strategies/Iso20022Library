// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RejectedReason67Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a code or proprietary format for a rejected reason.</summary>
    [IsoId("67082ee4-7488-4f45-ad8f-5eb10a065b9c")]
    [DisplayName("Rejected Reason 67 Choice")]
    [KnownType(typeof(RejectedReason67Choice.Code))]
    [KnownType(typeof(RejectedReason67Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason67Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason67Choice.Proprietary))]
    public abstract record RejectedReason67Choice_
    {
    }
}
