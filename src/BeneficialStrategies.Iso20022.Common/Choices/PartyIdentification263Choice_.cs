// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PartyIdentification263Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between different formats for the identification of a party.</summary>
    [IsoId("_Eg4H4a3pEfCN-rGCydxGUA")]
    [DisplayName("Party Identification 263 Choice")]
    [KnownType(typeof(AnyBIC))]
    [JsonDerivedType(typeof(AnyBIC), nameof(AnyBIC))]
    [KnownType(typeof(ProprietaryIdentification))]
    [JsonDerivedType(typeof(ProprietaryIdentification), nameof(ProprietaryIdentification))]
    [KnownType(typeof(NameAndAddress))]
    [JsonDerivedType(typeof(NameAndAddress), nameof(NameAndAddress))]
    [KnownType(typeof(IndividualOwnerIdentification))]
    [JsonDerivedType(typeof(IndividualOwnerIdentification), nameof(IndividualOwnerIdentification))]
    [KnownType(typeof(LEI))]
    [JsonDerivedType(typeof(LEI), nameof(LEI))]
    public abstract record PartyIdentification263Choice_;
}
