// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification23Choice
{
    /// <summary>
    /// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
    /// </summary>
    [IsoId("_ItDT-yqdEeObprHJy8Zrxg")]
    [DisplayName("Accounts List And Balance Details")]
    public record AccountsListAndBalanceDetails : AccountIdentification23Choice_
    {
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_JD9YFSqdEeObprHJy8Zrxg")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text SafekeepingAccount { get; init; }

        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_JD9YHSqdEeObprHJy8Zrxg")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public PartyIdentification36Choice_? AccountOwner { get; init; }

        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_JD9YJSqdEeObprHJy8Zrxg")]
        [DisplayName("Safekeeping Place")]
        [IsoXmlTag("SfkpgPlc")]
        public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; }

        /// <summary>
        /// Provides information about balance related to a corporate action.
        /// </summary>
        [IsoId("_JD9YLSqdEeObprHJy8Zrxg")]
        [DisplayName("Balance")]
        [IsoXmlTag("Bal")]
        public CorporateActionBalanceDetails21? Balance { get; init; }
    }
}
