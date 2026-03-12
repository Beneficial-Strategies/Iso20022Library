// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification50Choice
{
    /// <summary>
    /// Selected safekeeping accounts list to which the corporate action event applies.
    /// </summary>
    [IsoId("_pdA8Kzi7Eeydid5dcNPKvg")]
    [DisplayName("Accounts List")]
    public partial record AccountsList : AccountIdentification50Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_pdBi8Ti7Eeydid5dcNPKvg")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoRestrictedFINXMax35Text? SafekeepingAccount { get; init; } 
        
        /// <summary>
        /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
        /// </summary>
        [IsoId("_pdBi-Ti7Eeydid5dcNPKvg")]
        [DisplayName("Block Chain Address Or Wallet")]
        [IsoXmlTag("BlckChainAdrOrWllt")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public IsoRestrictedFINXMax140Text? BlockChainAddressOrWallet { get; init; } 
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_pdBi-zi7Eeydid5dcNPKvg")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public PartyIdentification136Choice_? AccountOwner { get; init; } 
        
        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_pdBjAzi7Eeydid5dcNPKvg")]
        [DisplayName("Safekeeping Place")]
        [IsoXmlTag("SfkpgPlc")]
        public SafekeepingPlaceFormat32Choice_? SafekeepingPlace { get; init; } 
        
        
        #nullable disable
        
    }
}
