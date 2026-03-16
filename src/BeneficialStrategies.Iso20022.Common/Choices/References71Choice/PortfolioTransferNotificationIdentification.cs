// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References71Choice
{
    /// <summary>
    /// Identification of the portfolio transfer.
    /// </summary>
    [IsoId("_KDxvySAaEeu4a6pNulzZ4Q")]
    [DisplayName("Portfolio Transfer Notification Identification")]
    public record PortfolioTransferNotificationIdentification : References71Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 16 characters. It has a pattern that disables the use of characters that is not part of the character set X, that is, that is not a-z A-Z / - ? : ( ) . , ‘ + , and disable the use of slash &quot;/&quot; at the beginning and end of line and double slash &quot;//&quot; within the line.
        /// </summary>
        [IsoXmlTag("PrtflTrfNtfctnId")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
        [StringLength(maximumLength: 16, MinimumLength = 1)]
        public required IsoRestrictedFINXMax16Text Value { get; init; }
    }
}
