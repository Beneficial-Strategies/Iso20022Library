// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References82Choice
{
    /// <summary>Specifies the pool identification.</summary>
    [IsoId("_4SiC2-SlEe-qVZLXW4RRBw")]
    [DisplayName("Pool Identification")]
    public record PoolIdentification : References82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PoolId")]
        public required IsoMax35Text Value { get; init; }
    }
}
