// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References60Choice
{
    /// <summary>
    /// Reference to a transaction that cannot be identified using a standard reference element present in the message.
    /// </summary>
    [IsoId("_8T7AuZNLEeWGlc8L7oPDIg")]
    [DisplayName("Other Transaction Identification")]
    public record OtherTransactionIdentification : References60Choice_
    {
        /// <summary>
        /// Message type number/message identifier of the message referenced in the linkage sequence.
        /// </summary>
        [IsoId("_8T7nsZNLEeWGlc8L7oPDIg")]
        [DisplayName("Message Number")]
        [IsoXmlTag("MsgNb")]
        public DocumentNumber16Choice_? MessageNumber { get; init; }

        /// <summary>
        /// Identification of the document.
        /// </summary>
        [IsoId("_8T7nuZNLEeWGlc8L7oPDIg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
        [StringLength(maximumLength: 16, MinimumLength = 1)]
        public required IsoRestrictedFINXMax16Text Identification { get; init; }
    }
}
