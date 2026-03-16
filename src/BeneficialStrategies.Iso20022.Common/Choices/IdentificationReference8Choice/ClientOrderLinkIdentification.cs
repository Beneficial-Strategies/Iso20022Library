// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference8Choice
{
    /// <summary>
    /// It permits order originators to tie together groups of orders in which trades resulting from orders are associated for a specific purpose, for example the calculation of average execution price for a customer.
    /// </summary>
    [IsoId("_AcF7ldokEeC60axPepSq7g_1543139442")]
    [DisplayName("Client Order Link Identification")]
    public record ClientOrderLinkIdentification : IdentificationReference8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("ClntOrdrLkId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
