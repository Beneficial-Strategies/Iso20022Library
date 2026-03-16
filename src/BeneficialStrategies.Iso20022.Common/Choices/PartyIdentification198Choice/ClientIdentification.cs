// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification198Choice
{
    /// <summary>
    /// Unique and unambiguous identification of the client&apos;s counterparty.
    /// </summary>
    [IsoId("_pDdK0TtqEemIf7eyjCwinw")]
    [DisplayName("Client Identification")]
    public record ClientIdentification : PartyIdentification198Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 50 characters.
        /// </summary>
        [IsoXmlTag("ClntId")]
        [IsoSimpleType(IsoSimpleType.Max50Text)]
        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public required IsoMax50Text Value { get; init; }
    }
}
