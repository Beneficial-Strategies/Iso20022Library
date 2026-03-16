// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification18Choice
{
    /// <summary>
    /// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
    /// </summary>
    [IsoId("_Jg42I_pTEeCLrd06h-p51g")]
    [DisplayName("Accounts List And Balance Details")]
    [IsoXmlTag("AcctsListAndBalDtls")]
    public record AccountsListAndBalanceDetails : AccountIdentification18Choice_
    {
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_Jg42M_pTEeCLrd06h-p51g")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text SafekeepingAccount { get; init; }

        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_Jg42PfpTEeCLrd06h-p51g")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public PartyIdentification36Choice_? AccountOwner { get; init; }

        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_Jg42R_pTEeCLrd06h-p51g")]
        [DisplayName("Safekeeping Place")]
        [IsoXmlTag("SfkpgPlc")]
        public SafekeepingPlaceFormat2Choice_? SafekeepingPlace { get; init; }

        /// <summary>
        /// Provides information about balance related to a corporate action.
        /// </summary>
        [IsoId("_Jg42UfpTEeCLrd06h-p51g")]
        [DisplayName("Balance")]
        [IsoXmlTag("Bal")]
        public CorporateActionBalanceDetails10? Balance { get; init; }
    }
}
