// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventProcessingType1FormatChoice
{
    /// <summary>
    /// Standard code to specify the type of event processing.
    /// </summary>
    [IsoId("_RmHAMtp-Ed-ak6NoX_4Aeg_-1265853518")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventProcessingType1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of event processing.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventProcessingType1Code Value { get; init; }
    }
}
