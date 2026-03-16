// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventStage1FormatChoice
{
    /// <summary>
    /// Standard code to specify the stage of the CA event.
    /// </summary>
    [IsoId("_RmHANdp-Ed-ak6NoX_4Aeg_1604374052")]
    [DisplayName("Code")]
    public record Code : CorporateActionEventStage1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the stage of the CA event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventStage1Code Value { get; init; }
    }
}
