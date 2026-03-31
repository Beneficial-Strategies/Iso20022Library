// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionOption2Choice
{
    /// <summary>
    /// Standard code to specify the type of corporate action options.
    /// </summary>
    [IsoId("_Q0yQ8tp-Ed-ak6NoX_4Aeg_1018925054")]
    [DisplayName("Code")]
    public record Code : CorporateActionOption2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of corporate action options.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionOption2Code Value { get; init; }
    }
}
