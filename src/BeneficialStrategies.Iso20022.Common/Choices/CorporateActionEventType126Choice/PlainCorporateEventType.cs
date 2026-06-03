// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType126Choice
{
    /// <summary>Type of corporate action event.</summary>
    [IsoId("_txvhwaNZEfC9id413JK-Ig")]
    [DisplayName("Plain Corporate Event Type")]
    public record PlainCorporateEventType : CorporateActionEventType126Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PlainCorpEvtTp")]
        public required CorporateActionEventType35Code Value { get; init; }
    }
}
