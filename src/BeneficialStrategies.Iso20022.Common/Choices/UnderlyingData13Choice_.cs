// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.UnderlyingData13Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for underlying payment or statement data.</summary>
    [IsoId("24af6bff-ee4a-4c33-908e-c0da6fcb6a57")]
    [DisplayName("Underlying Data 13 Choice")]
    [KnownType(typeof(UnderlyingData13Choice.Initiation))]
    [KnownType(typeof(UnderlyingData13Choice.Interbank))]
    [KnownType(typeof(UnderlyingData13Choice.StatementEntry))]
    [KnownType(typeof(UnderlyingData13Choice.Account))]
    [KnownType(typeof(UnderlyingData13Choice.Other))]
    [JsonDerivedType(typeof(UnderlyingData13Choice.Initiation))]
    [JsonDerivedType(typeof(UnderlyingData13Choice.Interbank))]
    [JsonDerivedType(typeof(UnderlyingData13Choice.StatementEntry))]
    [JsonDerivedType(typeof(UnderlyingData13Choice.Account))]
    [JsonDerivedType(typeof(UnderlyingData13Choice.Other))]
    public abstract record UnderlyingData13Choice_
    {
    }
}
