// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification55Choice
{
    /// <summary>
    /// Basic Bank Account Number (BBAN) - identifier used nationally by financial institutions, ie, in individual countries, generally as part of a National Account Numbering Scheme(s), to uniquely identify the account of a customer.
    /// </summary>
    [IsoId("_e6Hl8watEe2phaVG0lYKTw")]
    [DisplayName("BBAN")]
    public record BBAN : AccountIdentification55Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Basic Bank Account Number (BBAN). Identifier used nationally by financial institutions, ie, in individual countries, generally as part of a National Account Numbering Scheme(s), which uniquely identifies the account of a customer.
        /// </summary>
        [IsoXmlTag("BBAN")]
        [IsoSimpleType(IsoSimpleType.BBANIdentifier)]
        public required IsoBBANIdentifier Value { get; init; }
    }
}
