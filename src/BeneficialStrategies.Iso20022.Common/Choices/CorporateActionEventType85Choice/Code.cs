// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType85Choice
{
    /// <summary>
    /// Event types expressed as a code.
    /// </summary>
    [IsoId("_2C5p8-XmEemEj48jhmlA0Q")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventType85Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the corporate action event type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType29Code Value { get; init; }
    }
}
