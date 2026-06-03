// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.InvestigationDataRecord12Choice
{
    /// <summary>Provides additional information about the response in narrative form.</summary>
    [IsoId("632a9035-b94b-4fb4-95a5-b29c04b0ed30")]
    [DisplayName("Response Narrative")]
    public record ResponseNarrative : InvestigationDataRecord12Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("RspnNrrtv")]
        public required IsoMax500Text Value { get; init; }
    }
}
