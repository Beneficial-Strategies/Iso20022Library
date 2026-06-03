// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References83Choice
{
    /// <summary>Specifies the corporate action event identification.</summary>
    [IsoId("_Wt0M8KgzEfCXwLUUylXgrQ")]
    [DisplayName("Corporate Action Event Identification")]
    public record CorporateActionEventIdentification : References83Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CorpActnEvtId")]
        public required IsoMax35Text Value { get; init; }
    }
}
