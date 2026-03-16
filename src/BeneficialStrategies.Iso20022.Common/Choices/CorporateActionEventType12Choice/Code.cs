// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType12Choice
{
    /// <summary>
    /// Event types expressed as a code.
    /// </summary>
    [IsoId("_qRaiUQ4zEeKVsZQr6J31Tg")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventType12Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of a corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventType11Code Value { get; init; }
    }
}
