// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PartyIdentification336Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Identification of a party.</summary>
    [IsoId("_wIt64anVEfC5VNwixU6YfQ")]
    [DisplayName("Party Identification 336 Choice")]
    [KnownType(typeof(AnyBIC))]
    [JsonDerivedType(typeof(AnyBIC), nameof(AnyBIC))]
    [KnownType(typeof(LEI))]
    [JsonDerivedType(typeof(LEI), nameof(LEI))]
    public abstract record PartyIdentification336Choice_;
}
