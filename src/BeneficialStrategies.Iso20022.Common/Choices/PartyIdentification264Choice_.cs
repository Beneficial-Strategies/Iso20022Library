// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PartyIdentification264Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Identification of a party.</summary>
    [IsoId("_Qdy5ga5wEfCUHaCK5HWOhg")]
    [DisplayName("Party Identification 264 Choice")]
    [KnownType(typeof(LegalPerson))]
    [JsonDerivedType(typeof(LegalPerson), nameof(LegalPerson))]
    [KnownType(typeof(NaturalPerson))]
    [JsonDerivedType(typeof(NaturalPerson), nameof(NaturalPerson))]
    public abstract record PartyIdentification264Choice_;
}
