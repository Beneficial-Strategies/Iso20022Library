// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.OfferTypeFormat18Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a standard code or proprietary code to specify the type of offer.</summary>
    [IsoId("_h0jmgfIHEfCS-OXqezZQmw")]
    [DisplayName("Offer Type Format 18 Choice")]
    [KnownType(typeof(Code))]
    [JsonDerivedType(typeof(Code), nameof(Code))]
    [KnownType(typeof(Proprietary))]
    [JsonDerivedType(typeof(Proprietary), nameof(Proprietary))]
    public abstract record OfferTypeFormat18Choice_;
}
