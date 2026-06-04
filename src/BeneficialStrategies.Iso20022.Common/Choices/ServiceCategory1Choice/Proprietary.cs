// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ServiceCategory1Choice
{
    /// <summary>Service category expressed as a proprietary code.</summary>
    [IsoId("_kjVzcJudEey__7eNd9lW5Q")]
    [DisplayName("Proprietary")]
    public record Proprietary : ServiceCategory1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax4AlphaNumericText Value { get; init; }
    }
}
