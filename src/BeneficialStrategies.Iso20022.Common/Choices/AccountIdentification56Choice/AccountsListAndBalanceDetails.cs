// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification56Choice
{
    /// <summary>
    /// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
    /// </summary>
    [IsoId("_Q6fvWzgDEe23pOhj-2WbKw")]
    [DisplayName("Accounts List And Balance Details")]
    public record AccountsListAndBalanceDetails : AccountIdentification56Choice_
    {
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_RSyTizgDEe23pOhj-2WbKw")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? SafekeepingAccount { get; init; }

        /// <summary>
        /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
        /// </summary>
        [IsoId("_RSyTkzgDEe23pOhj-2WbKw")]
        [DisplayName("Block Chain Address Or Wallet")]
        [IsoXmlTag("BlckChainAdrOrWllt")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? BlockChainAddressOrWallet { get; init; }

        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_RSyTlTgDEe23pOhj-2WbKw")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public PartyIdentification127Choice_? AccountOwner { get; init; }

        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_RSyTnTgDEe23pOhj-2WbKw")]
        [DisplayName("Safekeeping Place")]
        [IsoXmlTag("SfkpgPlc")]
        public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; }

        /// <summary>
        /// Provides information about balance related to a corporate action.
        /// </summary>
        [IsoId("_RSyTpTgDEe23pOhj-2WbKw")]
        [DisplayName("Balance")]
        [IsoXmlTag("Bal")]
        public CorporateActionBalanceDetails43? Balance { get; init; }
    }
}
