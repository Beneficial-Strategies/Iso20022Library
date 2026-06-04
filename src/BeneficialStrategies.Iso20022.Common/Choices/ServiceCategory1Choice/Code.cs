// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ServiceCategory1Choice
{
    /// <summary>Service category expressed as a code.</summary>
    [IsoId("_iY6jQJudEey__7eNd9lW5Q")]
    [DisplayName("Code")]
    public record Code : ServiceCategory1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required ExternalServiceCategory1Code Value { get; init; }
    }
}
