// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification33Choice
{
    /// <summary>
    /// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
    /// </summary>
    [IsoId("_xKO_Szq3EeWQ1Y7f8kds2A")]
    [DisplayName("Accounts List And Balance Details")]
    public record AccountsListAndBalanceDetails : AccountIdentification33Choice_
    {
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_xWboNTq3EeWQ1Y7f8kds2A")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text SafekeepingAccount { get; init; }

        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_xWboPTq3EeWQ1Y7f8kds2A")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public PartyIdentification92Choice_? AccountOwner { get; init; }

        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_xWboRTq3EeWQ1Y7f8kds2A")]
        [DisplayName("Safekeeping Place")]
        [IsoXmlTag("SfkpgPlc")]
        public SafekeepingPlaceFormat8Choice_? SafekeepingPlace { get; init; }

        /// <summary>
        /// Balance to which the payment applies (less or equal to the total eligible balance).
        /// </summary>
        [IsoId("_xWboTTq3EeWQ1Y7f8kds2A")]
        [DisplayName("Confirmed Balance")]
        [IsoXmlTag("ConfdBal")]
        public required BalanceFormat5Choice_ ConfirmedBalance { get; init; }
    }
}
