// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References83Choice
{
    /// <summary>Specifies the pool identification.</summary>
    [IsoId("_Wt0M2KgzEfCXwLUUylXgrQ")]
    [DisplayName("Pool Identification")]
    public partial record PoolIdentification : References83Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PoolId")]
        public required Max35Text Value { get; init; }
    }
}
