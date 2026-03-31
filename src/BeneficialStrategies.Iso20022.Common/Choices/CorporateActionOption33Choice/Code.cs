// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionOption33Choice
{
    /// <summary>
    /// Option type expressed as a code.
    /// </summary>
    [IsoId("_xPNmgeasEemtTOaHuc_63w")]
    [DisplayName("Code")]
    public record Code : CorporateActionOption33Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of corporate action options.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionOption12Code Value { get; init; }
    }
}
