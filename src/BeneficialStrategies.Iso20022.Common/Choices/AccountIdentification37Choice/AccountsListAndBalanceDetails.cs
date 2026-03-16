// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification37Choice
{
    /// <summary>
    /// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
    /// </summary>
    [IsoId("_c4bUC5KQEeWHWpTQn1FFVg")]
    [DisplayName("Accounts List And Balance Details")]
    public record AccountsListAndBalanceDetails : AccountIdentification37Choice_
    {
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_c4b7AZKQEeWHWpTQn1FFVg")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; }

        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_c4b7CZKQEeWHWpTQn1FFVg")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public PartyIdentification103Choice_? AccountOwner { get; init; }

        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_c4b7EZKQEeWHWpTQn1FFVg")]
        [DisplayName("Safekeeping Place")]
        [IsoXmlTag("SfkpgPlc")]
        public SafekeepingPlaceFormat11Choice_? SafekeepingPlace { get; init; }

        /// <summary>
        /// Balance to which the payment applies (less or equal to the total eligible balance).
        /// </summary>
        [IsoId("_c4b7GZKQEeWHWpTQn1FFVg")]
        [DisplayName("Confirmed Balance")]
        [IsoXmlTag("ConfdBal")]
        public required BalanceFormat7Choice_ ConfirmedBalance { get; init; }
    }
}
