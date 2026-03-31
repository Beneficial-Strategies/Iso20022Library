// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionOption1FormatChoice
{
    /// <summary>
    /// Option type expressed as a code.
    /// </summary>
    [IsoId("_RlgjQdp-Ed-ak6NoX_4Aeg_-1093032102")]
    [DisplayName("Code")]
    public record Code : CorporateActionOption1FormatChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of CA options.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionOptionType1Code Value { get; init; }
    }
}
