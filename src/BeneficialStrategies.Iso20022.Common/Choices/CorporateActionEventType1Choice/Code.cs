// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType1Choice
{
    /// <summary>
    /// Corporate action event type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_QwUAoNp-Ed-ak6NoX_4Aeg_2018145477")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the corporate action event type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType3Code Value { get; init; }
    }
}
