// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.OfferTypeFormat17Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a standard code or proprietary code to specify the type of offer.</summary>
    [IsoId("d321b6c5-e4b1-4dfe-8f99-38aab0b140db")]
    [DisplayName("Offer Type Format 17 Choice")]
    [KnownType(typeof(Code))]
    [JsonDerivedType(typeof(Code), nameof(Code))]
    [KnownType(typeof(Proprietary))]
    [JsonDerivedType(typeof(Proprietary), nameof(Proprietary))]
    public abstract record OfferTypeFormat17Choice_;
}
