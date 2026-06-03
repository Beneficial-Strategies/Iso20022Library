// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.References82Choice
{
    /// <summary>Specifies the corporate action event identification.</summary>
    [IsoId("_4SiC4-SlEe-qVZLXW4RRBw")]
    [DisplayName("Corporate Action Event Identification")]
    public record CorporateActionEventIdentification : References82Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CorpActnEvtId")]
        public required IsoMax35Text Value { get; init; }
    }
}
