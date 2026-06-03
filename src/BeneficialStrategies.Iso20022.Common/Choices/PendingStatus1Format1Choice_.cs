// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingStatus1Format1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of formats to express the pending status of the notification advice.</summary>
    [IsoId("_pJuWYaUdEfCnE_wCEfCqTA")]
    [DisplayName("Pending Status 1 Format 1 Choice")]
    [KnownType(typeof(PendingStatus1Format1Choice.Code))]
    [KnownType(typeof(PendingStatus1Format1Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingStatus1Format1Choice.Code))]
    [JsonDerivedType(typeof(PendingStatus1Format1Choice.Proprietary))]
    public abstract record PendingStatus1Format1Choice_
    {
    }
}
