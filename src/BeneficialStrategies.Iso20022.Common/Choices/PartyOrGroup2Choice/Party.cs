// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyOrGroup2Choice
{
    /// <summary>
    /// Specifies a party.
    /// </summary>
    [IsoId("_DDQTg249EeiU9cctagi5ow")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public record Party : PartyOrGroup2Choice_
    {
        /// <summary>
        /// Entity involved in an activity.
        /// </summary>
        [IsoXmlTag("Pty")]
        public required PartyIdentification135 Value { get; init; }

        /// <summary>
        /// Security certificate used to sign electronically.
        /// </summary>
        [IsoId("_DOvKw249EeiU9cctagi5ow")]
        [DisplayName("Certificate")]
        [IsoXmlTag("Cert")]
        [IsoSimpleType(IsoSimpleType.Max10KBinary)]
        public IsoMax10KBinary? Certificate { get; init; }
    }
}
