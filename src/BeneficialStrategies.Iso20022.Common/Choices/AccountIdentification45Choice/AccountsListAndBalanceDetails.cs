// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification45Choice
{
    /// <summary>
    /// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
    /// </summary>
    [IsoId("_csxik_fSEeiNZp_PtLohLw")]
    [DisplayName("Accounts List And Balance Details")]
    public partial record AccountsListAndBalanceDetails : AccountIdentification45Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_csxin_fSEeiNZp_PtLohLw")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_csxip_fSEeiNZp_PtLohLw")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public PartyIdentification136Choice_? AccountOwner { get; init; } 
        
        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_csxir_fSEeiNZp_PtLohLw")]
        [DisplayName("Safekeeping Place")]
        [IsoXmlTag("SfkpgPlc")]
        public SafekeepingPlaceFormat32Choice_? SafekeepingPlace { get; init; } 
        
        /// <summary>
        /// Provides information about balance related to a corporate action.
        /// </summary>
        [IsoId("_csxit_fSEeiNZp_PtLohLw")]
        [DisplayName("Balance")]
        [IsoXmlTag("Bal")]
        public CorporateActionBalanceDetails36? Balance { get; init; } 
        
        
        #nullable disable
        
    }
}
