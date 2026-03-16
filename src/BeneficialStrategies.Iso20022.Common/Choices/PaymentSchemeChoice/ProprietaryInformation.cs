// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentSchemeChoice
{
    /// <summary>
    /// Channel that is specific to a user community and is required for use within that user community.||Usage: if the channel is included in the list of codes provided for the payment scheme, the code element should be used instead of the proprietary element.
    /// </summary>
    [IsoId("_QHyBENp-Ed-ak6NoX_4Aeg_-84180804")]
    [DisplayName("Proprietary Information")]
    public record ProprietaryInformation : PaymentSchemeChoice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("PrtryInf")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
