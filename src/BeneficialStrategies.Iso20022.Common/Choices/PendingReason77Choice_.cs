// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingReason77Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the pending reason.</summary>
    [IsoId("daf78ecf-aee5-4815-94bc-383784d69cde")]
    [DisplayName("Pending Reason 77 Choice")]
    [KnownType(typeof(PendingReason77Choice.Code))]
    [KnownType(typeof(PendingReason77Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason77Choice.Code))]
    [JsonDerivedType(typeof(PendingReason77Choice.Proprietary))]
    public abstract record PendingReason77Choice_
    {
    }
}
