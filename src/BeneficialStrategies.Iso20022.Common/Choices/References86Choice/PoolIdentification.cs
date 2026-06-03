// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References86Choice
{
    /// <summary>Specifies the pool identification.</summary>
    [IsoId("2f483e9f-8ff1-4c1d-a0ec-86b66f54d2db")]
    [DisplayName("Pool Identification")]
    public record PoolIdentification : References86Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PoolId")]
        public required IsoMax35Text Value { get; init; }
    }
}
