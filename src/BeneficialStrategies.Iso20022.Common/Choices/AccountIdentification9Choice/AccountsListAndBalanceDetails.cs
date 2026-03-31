// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification9Choice
{
    /// <summary>
    /// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
    /// </summary>
    [IsoId("_QSXgYdp-Ed-ak6NoX_4Aeg_1685362038")]
    [DisplayName("Accounts List And Balance Details")]
    [IsoXmlTag("AcctsListAndBalDtls")]
    public record AccountsListAndBalanceDetails : AccountIdentification9Choice_
    {
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_QSqbVdp-Ed-ak6NoX_4Aeg_-1432012403")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text SafekeepingAccount { get; init; }

        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_QSqbVtp-Ed-ak6NoX_4Aeg_1979721606")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public PartyIdentification13Choice_? AccountOwner { get; init; }

        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_QSqbV9p-Ed-ak6NoX_4Aeg_-669978255")]
        [DisplayName("Safekeeping Place")]
        [IsoXmlTag("SfkpgPlc")]
        public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; }

        /// <summary>
        /// Balance to which the payment applies (less or equal to the total eligible balance).
        /// </summary>
        [IsoId("_QSqbWNp-Ed-ak6NoX_4Aeg_-1460025098")]
        [DisplayName("Confirmed Balance")]
        [IsoXmlTag("ConfdBal")]
        public required BalanceFormat1Choice_ ConfirmedBalance { get; init; }
    }
}
