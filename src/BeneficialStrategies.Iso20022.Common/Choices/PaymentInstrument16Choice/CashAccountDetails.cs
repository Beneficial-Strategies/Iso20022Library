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
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument16Choice
{
    /// <summary>
    /// Cash account to credit for the payment of the dividends or of the redeemed investments funds or of interest.
    /// </summary>
    [IsoId("_MgQvWxdKEeK5g-3oYI0_9Q")]
    [DisplayName("Cash Account Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CashAccountDetails : PaymentInstrument16Choice_
    #else
    public partial class CashAccountDetails : PaymentInstrument16Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CashAccountDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CashAccountDetails( AccountIdentificationAndName3 reqIdentification )
        {
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_ar93iRczEeK5g-3oYI0_9Q")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AccountIdentificationAndName3 Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AccountIdentificationAndName3 Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentificationAndName3 Identification { get; init; } 
        #else
        public AccountIdentificationAndName3 Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_ar93jRczEeK5g-3oYI0_9Q")]
        [DisplayName("Account Owner")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctOwnr")]
        #endif
        [IsoXmlTag("AcctOwnr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification2Choice_? AccountOwner { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification2Choice_? AccountOwner { get; init; } 
        #else
        public PartyIdentification2Choice_? AccountOwner { get; set; } 
        #endif
        
        /// <summary>
        /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
        /// </summary>
        [IsoId("_ar93kRczEeK5g-3oYI0_9Q")]
        [DisplayName("Account Servicer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctSvcr")]
        #endif
        [IsoXmlTag("AcctSvcr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification2Choice_? AccountServicer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification2Choice_? AccountServicer { get; init; } 
        #else
        public PartyIdentification2Choice_? AccountServicer { get; set; } 
        #endif
        
        /// <summary>
        /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
        /// </summary>
        [IsoId("_ar93lRczEeK5g-3oYI0_9Q")]
        [DisplayName("Account Servicer Branch")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctSvcrBrnch")]
        #endif
        [IsoXmlTag("AcctSvcrBrnch")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchData? AccountServicerBranch { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchData? AccountServicerBranch { get; init; } 
        #else
        public BranchData? AccountServicerBranch { get; set; } 
        #endif
        
        /// <summary>
        /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, ISA.
        /// </summary>
        [IsoId("_698SoBdKEeK5g-3oYI0_9Q")]
        [DisplayName("Investment Account Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InvstmtAcctTp")]
        #endif
        [IsoXmlTag("InvstmtAcctTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InvestmentAccountType1Choice_? InvestmentAccountType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InvestmentAccountType1Choice_? InvestmentAccountType { get; init; } 
        #else
        public InvestmentAccountType1Choice_? InvestmentAccountType { get; set; } 
        #endif
        
        /// <summary>
        /// Other identification such as national registration identification number, passport number.
        /// </summary>
        [IsoId("_xpDeUBczEeK5g-3oYI0_9Q")]
        [DisplayName("Account Owner Other Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctOwnrOthrId")]
        #endif
        [IsoXmlTag("AcctOwnrOthrId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public GenericIdentification46? AccountOwnerOtherIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericIdentification46? AccountOwnerOtherIdentification { get; init; } 
        #else
        public GenericIdentification46? AccountOwnerOtherIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
