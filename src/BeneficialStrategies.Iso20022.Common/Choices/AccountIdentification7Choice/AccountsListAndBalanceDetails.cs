// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification7Choice
{
    /// <summary>
    /// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
    /// </summary>
    [IsoId("_QSXgZNp-Ed-ak6NoX_4Aeg_1363478372")]
    [DisplayName("Accounts List And Balance Details")]
    public record AccountsListAndBalanceDetails : AccountIdentification7Choice_
    {
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_QTHHRdp-Ed-ak6NoX_4Aeg_-986491653")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text SafekeepingAccount { get; init; }

        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_QTHHRtp-Ed-ak6NoX_4Aeg_-929232994")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public PartyIdentification13Choice_? AccountOwner { get; init; }

        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_QTHHR9p-Ed-ak6NoX_4Aeg_-917225808")]
        [DisplayName("Safekeeping Place")]
        [IsoXmlTag("SfkpgPlc")]
        public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; }

        /// <summary>
        /// Provides information about balance related to a corporate action.
        /// </summary>
        [IsoId("_QTHHSNp-Ed-ak6NoX_4Aeg_1292802646")]
        [DisplayName("Balance")]
        [IsoXmlTag("Bal")]
        public CorporateActionBalanceDetails1? Balance { get; init; }
    }
}
