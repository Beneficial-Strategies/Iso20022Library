// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PriceType6Choice
{
    /// <summary>Specifies the price type as a code.</summary>
    [IsoId("15c2c360-0023-4dd4-b806-3d33e47f66cd")]
    [DisplayName("Code")]
    public record Code : PriceType6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required TypeOfPrice9Code Value { get; init; }
    }
}
