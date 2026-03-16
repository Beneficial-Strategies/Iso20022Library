// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType5Choice
{
    /// <summary>
    /// Event types expressed as a code.
    /// </summary>
    [IsoId("_5QYQ0ffcEd-5M-tMFgHEdw")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventType5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of a corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType7Code Value { get; init; }
    }
}
