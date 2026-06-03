// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PartyIdentification262Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of formats for the identification of a party.</summary>
    [IsoId("82a95e44-4da4-4588-93ac-6464614b83af")]
    [DisplayName("Party Identification 262 Choice")]
    [KnownType(typeof(AnyBIC))]
    [JsonDerivedType(typeof(AnyBIC), nameof(AnyBIC))]
    [KnownType(typeof(ProprietaryIdentification))]
    [JsonDerivedType(typeof(ProprietaryIdentification), nameof(ProprietaryIdentification))]
    [KnownType(typeof(NameAndAddress))]
    [JsonDerivedType(typeof(NameAndAddress), nameof(NameAndAddress))]
    [KnownType(typeof(DigitalLedgerIdentification))]
    [JsonDerivedType(typeof(DigitalLedgerIdentification), nameof(DigitalLedgerIdentification))]
    public abstract record PartyIdentification262Choice_;
}
