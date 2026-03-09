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
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification37Choice
{
    /// <summary>
    /// Selected safekeeping accounts list (and optionally balance information) to which the corporate action event applies.
    /// </summary>
    [IsoId("_c4bUC5KQEeWHWpTQn1FFVg")]
    [DisplayName("Accounts List And Balance Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AccountsListAndBalanceDetails : AccountIdentification37Choice_
    #else
    public partial class AccountsListAndBalanceDetails : AccountIdentification37Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AccountsListAndBalanceDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AccountsListAndBalanceDetails( System.String reqSafekeepingAccount,BalanceFormat7Choice_ reqConfirmedBalance )
        {
            SafekeepingAccount = reqSafekeepingAccount;
            ConfirmedBalance = reqConfirmedBalance;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Account where financial instruments are maintained.
        /// </summary>
        [IsoId("_c4b7AZKQEeWHWpTQn1FFVg")]
        [DisplayName("Safekeeping Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SfkpgAcct")]
        #endif
        [IsoXmlTag("SfkpgAcct")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String SafekeepingAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String SafekeepingAccount { get; init; } 
        #else
        public System.String SafekeepingAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_c4b7CZKQEeWHWpTQn1FFVg")]
        [DisplayName("Account Owner")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctOwnr")]
        #endif
        [IsoXmlTag("AcctOwnr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification103Choice_? AccountOwner { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification103Choice_? AccountOwner { get; init; } 
        #else
        public PartyIdentification103Choice_? AccountOwner { get; set; } 
        #endif
        
        /// <summary>
        /// Location where the financial instruments are/will be safekept.
        /// </summary>
        [IsoId("_c4b7EZKQEeWHWpTQn1FFVg")]
        [DisplayName("Safekeeping Place")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SfkpgPlc")]
        #endif
        [IsoXmlTag("SfkpgPlc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SafekeepingPlaceFormat11Choice_? SafekeepingPlace { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SafekeepingPlaceFormat11Choice_? SafekeepingPlace { get; init; } 
        #else
        public SafekeepingPlaceFormat11Choice_? SafekeepingPlace { get; set; } 
        #endif
        
        /// <summary>
        /// Balance to which the payment applies (less or equal to the total eligible balance).
        /// </summary>
        [IsoId("_c4b7GZKQEeWHWpTQn1FFVg")]
        [DisplayName("Confirmed Balance")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ConfdBal")]
        #endif
        [IsoXmlTag("ConfdBal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required BalanceFormat7Choice_ ConfirmedBalance { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required BalanceFormat7Choice_ ConfirmedBalance { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BalanceFormat7Choice_ ConfirmedBalance { get; init; } 
        #else
        public BalanceFormat7Choice_ ConfirmedBalance { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
