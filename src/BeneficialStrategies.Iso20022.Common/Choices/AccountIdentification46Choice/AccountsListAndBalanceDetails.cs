// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification46Choice
{
    /// <summary>
    /// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
    /// </summary>
    [IsoId("_0_amjffSEeiNZp_PtLohLw")]
    [DisplayName("Accounts List And Balance Details")]
    public partial record AccountsListAndBalanceDetails : AccountIdentification46Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_0_ammffSEeiNZp_PtLohLw")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_0_amoffSEeiNZp_PtLohLw")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public PartyIdentification136Choice_? AccountOwner { get; init; } 
        
        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_0_amqffSEeiNZp_PtLohLw")]
        [DisplayName("Safekeeping Place")]
        [IsoXmlTag("SfkpgPlc")]
        public SafekeepingPlaceFormat32Choice_? SafekeepingPlace { get; init; } 
        
        /// <summary>
        /// Balance to which the payment applies (less or equal to the total eligible balance).
        /// </summary>
        [IsoId("_0_amsffSEeiNZp_PtLohLw")]
        [DisplayName("Confirmed Balance")]
        [IsoXmlTag("ConfdBal")]
        public required BalanceFormat7Choice_ ConfirmedBalance { get; init; } 
        
        
        #nullable disable
        
    }
}
