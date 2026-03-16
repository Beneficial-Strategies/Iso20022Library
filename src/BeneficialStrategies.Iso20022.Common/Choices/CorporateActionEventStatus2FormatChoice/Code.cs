// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventStatus2FormatChoice
{
    /// <summary>
    /// Standard code to specify the status of the CA option.
    /// </summary>
    [IsoId("_RmQKItp-Ed-ak6NoX_4Aeg_-1374576221")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventStatus2FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of the CA option.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventStatus2Code Value { get; init; }
    }
}
