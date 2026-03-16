// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionOption46Choice
{
    /// <summary>
    /// Standard code to specify the type of corporate action options.
    /// </summary>
    [IsoId("_ZHezAR9REeuFz_FaCzCLgQ")]
    [DisplayName("Code")]
    public record Code : CorporateActionOption46Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of corporate action options.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionOption15Code Value { get; init; }
    }
}
