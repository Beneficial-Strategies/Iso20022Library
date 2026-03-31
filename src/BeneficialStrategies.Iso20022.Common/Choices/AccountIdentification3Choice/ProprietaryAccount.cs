// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification3Choice
{
    /// <summary>
    /// Account number used by financial institutions in individual countries to identify an account of a customer, but not necessarily the bank and branch of the financial institution in which the account is held.
    /// </summary>
    [IsoId("_PdwzoNp-Ed-ak6NoX_4Aeg_-1485477198")]
    [DisplayName("Proprietary Account")]
    public record ProprietaryAccount : AccountIdentification3Choice_
    {
        /// <summary>
        /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
        /// </summary>
        [IsoId("_P_u4QNp-Ed-ak6NoX_4Aeg_618188642")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max34Text)]
        [StringLength(maximumLength: 34, MinimumLength = 1)]
        public required IsoMax34Text Identification { get; init; }
    }
}
