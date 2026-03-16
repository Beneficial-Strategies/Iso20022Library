// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType105Choice
{
    /// <summary>
    /// Extended Corporate Event Type.
    /// </summary>
    [DisplayName("Extended Corporate Event Type")]
    public record ExtendedCorporateEventType : CorporateActionEventType105Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("XtndedCorpEvtTp")]
        public required ExtendedEventType7Code Value { get; init; }
    }
}
