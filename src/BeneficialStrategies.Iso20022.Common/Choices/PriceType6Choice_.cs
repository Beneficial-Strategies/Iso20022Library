// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PriceType6Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Type and information about a price.</summary>
    [IsoId("02138829-f85e-4b11-93a5-29d9381fd059")]
    [DisplayName("Price Type 6 Choice")]
    [KnownType(typeof(PriceType6Choice.Code))]
    [KnownType(typeof(PriceType6Choice.Proprietary))]
    [JsonDerivedType(typeof(PriceType6Choice.Code))]
    [JsonDerivedType(typeof(PriceType6Choice.Proprietary))]
    public abstract record PriceType6Choice_
    {
    }
}
