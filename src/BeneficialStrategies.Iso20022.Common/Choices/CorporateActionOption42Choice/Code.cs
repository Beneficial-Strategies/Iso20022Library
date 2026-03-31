// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionOption42Choice
{
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_BHW2ax9QEeuFz_FaCzCLgQ")]
    [DisplayName("Code")]
    public record Code : CorporateActionOption42Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of corporate action options.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionOption17Code Value { get; init; }
    }
}
