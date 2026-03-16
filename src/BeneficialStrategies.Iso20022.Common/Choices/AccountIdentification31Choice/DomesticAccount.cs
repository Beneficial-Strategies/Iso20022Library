// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification31Choice
{
    /// <summary>
    /// Account number used by financial institutions in individual countries to identify an account of a customer, but not necessarily the bank and branch of the financial institution in which the account is held.
    /// </summary>
    [IsoId("_su6ah_SaEeSfzLT5J5kvFg")]
    [DisplayName("Domestic Account")]
    public record DomesticAccount : AccountIdentification31Choice_
    {
        /// <summary>
        /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
        /// </summary>
        [IsoId("_n2FZYSxxEeKgiYs1KJCQUg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }
    }
}
