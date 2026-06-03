// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References83Choice
{
    /// <summary>Specifies the common identification.</summary>
    [IsoId("_Wt0M4KgzEfCXwLUUylXgrQ")]
    [DisplayName("Common Identification")]
    public record CommonIdentification : References83Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CmonId")]
        public required IsoMax35Text Value { get; init; }
    }
}
