// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType57Choice
{
    /// <summary>
    /// Event types expressed as a code.
    /// </summary>
    [IsoId("_sb-58ZwqEeazcsnODTksnQ")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventType57Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the corporate action event type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType22Code Value { get; init; }
    }
}
