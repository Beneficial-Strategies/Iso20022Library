// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType3Choice
{
    /// <summary>
    /// Event types expressed as a code.
    /// </summary>
    [IsoId("_Q4g6Y9p-Ed-ak6NoX_4Aeg_489319319")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventType3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of a corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType6Code Value { get; init; }
    }
}
