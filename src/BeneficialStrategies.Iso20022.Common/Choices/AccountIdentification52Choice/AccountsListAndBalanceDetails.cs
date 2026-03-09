// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification52Choice
{
    /// <summary>
    /// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
    /// </summary>
    [IsoId("_ps_Rtzi7Eeydid5dcNPKvg")]
    [DisplayName("Accounts List And Balance Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AccountsListAndBalanceDetails : AccountIdentification52Choice_
    #else
    public partial class AccountsListAndBalanceDetails : AccountIdentification52Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_ps_RyTi7Eeydid5dcNPKvg")]
        [DisplayName("Safekeeping Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SfkpgAcct")]
        #endif
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoRestrictedFINXMax35Text? SafekeepingAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SafekeepingAccount { get; init; } 
        #else
        public System.String? SafekeepingAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
        /// </summary>
        [IsoId("_ps_R0Ti7Eeydid5dcNPKvg")]
        [DisplayName("Block Chain Address Or Wallet")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BlckChainAdrOrWllt")]
        #endif
        [IsoXmlTag("BlckChainAdrOrWllt")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoRestrictedFINXMax140Text? BlockChainAddressOrWallet { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? BlockChainAddressOrWallet { get; init; } 
        #else
        public System.String? BlockChainAddressOrWallet { get; set; } 
        #endif
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_ps_R0zi7Eeydid5dcNPKvg")]
        [DisplayName("Account Owner")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctOwnr")]
        #endif
        [IsoXmlTag("AcctOwnr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification136Choice_? AccountOwner { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification136Choice_? AccountOwner { get; init; } 
        #else
        public PartyIdentification136Choice_? AccountOwner { get; set; } 
        #endif
        
        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_ps_R2zi7Eeydid5dcNPKvg")]
        [DisplayName("Safekeeping Place")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SfkpgPlc")]
        #endif
        [IsoXmlTag("SfkpgPlc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SafekeepingPlaceFormat32Choice_? SafekeepingPlace { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SafekeepingPlaceFormat32Choice_? SafekeepingPlace { get; init; } 
        #else
        public SafekeepingPlaceFormat32Choice_? SafekeepingPlace { get; set; } 
        #endif
        
        /// <summary>
        /// Provides information about balance related to a corporate action.
        /// </summary>
        [IsoId("_ps_R4zi7Eeydid5dcNPKvg")]
        [DisplayName("Balance")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Bal")]
        #endif
        [IsoXmlTag("Bal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CorporateActionBalanceDetails46? Balance { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CorporateActionBalanceDetails46? Balance { get; init; } 
        #else
        public CorporateActionBalanceDetails46? Balance { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
