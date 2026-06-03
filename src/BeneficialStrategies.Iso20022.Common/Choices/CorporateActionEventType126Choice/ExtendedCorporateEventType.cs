// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType126Choice
{
    /// <summary>Extended list of corporate action event types.</summary>
    [IsoId("_txvhw6NZEfC9id413JK-Ig")]
    [DisplayName("Extended Corporate Event Type")]
    public record ExtendedCorporateEventType : CorporateActionEventType126Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("XtndedCorpEvtTp")]
        public required ExtendedEventType8Code Value { get; init; }
    }
}
