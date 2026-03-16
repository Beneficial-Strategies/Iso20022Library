// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType8Choice
{
    /// <summary>
    /// Event types expressed as a code.
    /// </summary>
    [IsoId("_JPlZKfmREeC_eLZALo-S0A")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventType8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of a corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType9Code Value { get; init; }
    }
}
