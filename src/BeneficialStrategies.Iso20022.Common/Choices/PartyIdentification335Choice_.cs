// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PartyIdentification335Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Identification of a party.</summary>
    [IsoId("_r9ikgajQEfCzuLlmLrhIvA")]
    [DisplayName("Party Identification 335 Choice")]
    [KnownType(typeof(Account))]
    [JsonDerivedType(typeof(Account), nameof(Account))]
    [KnownType(typeof(Party))]
    [JsonDerivedType(typeof(Party), nameof(Party))]
    public abstract record PartyIdentification335Choice_;
}
