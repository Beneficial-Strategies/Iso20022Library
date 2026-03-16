// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification29Choice
{
    /// <summary>
    /// Selected safekeeping accounts list to which the corporate action event applies.
    /// </summary>
    [IsoId("_xuYOKzq3EeWQ1Y7f8kds2A")]
    [DisplayName("Accounts List")]
    [IsoXmlTag("AcctsList")]
    public record AccountsList : AccountIdentification29Choice_
    {
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_w9u0VTq3EeWQ1Y7f8kds2A")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text SafekeepingAccount { get; init; }

        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_w9u0XTq3EeWQ1Y7f8kds2A")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public PartyIdentification92Choice_? AccountOwner { get; init; }

        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_w9u0ZTq3EeWQ1Y7f8kds2A")]
        [DisplayName("Safekeeping Place")]
        [IsoXmlTag("SfkpgPlc")]
        public SafekeepingPlaceFormat8Choice_? SafekeepingPlace { get; init; }
    }
}
