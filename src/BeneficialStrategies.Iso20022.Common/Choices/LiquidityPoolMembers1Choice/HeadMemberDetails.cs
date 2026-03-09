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
namespace BeneficialStrategies.Iso20022.Choices.LiquidityPoolMembers1Choice
{
    /// <summary>
    /// Information about head member of liquidity pool.
    /// </summary>
    [IsoId("_zpIWcCDsEeav65mEytrgaA")]
    [DisplayName("Head Member Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record HeadMemberDetails : LiquidityPoolMembers1Choice_
    #else
    public partial class HeadMemberDetails : LiquidityPoolMembers1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a HeadMemberDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public HeadMemberDetails( CashAccount24 reqAccount,FinancialInstitutionIdentification9 reqAccountOwner )
        {
            Account = reqAccount;
            AccountOwner = reqAccountOwner;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Account identifier.
        /// </summary>
        [IsoId("_UhRGkCDsEeav65mEytrgaA")]
        [DisplayName("Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Acct")]
        #endif
        [IsoXmlTag("Acct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CashAccount24 Account { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CashAccount24 Account { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount24 Account { get; init; } 
        #else
        public CashAccount24 Account { get; set; } 
        #endif
        
        /// <summary>
        /// Account owner identification.
        /// </summary>
        [IsoId("_eOrnECDsEeav65mEytrgaA")]
        [DisplayName("Account Owner")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctOwnr")]
        #endif
        [IsoXmlTag("AcctOwnr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstitutionIdentification9 AccountOwner { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FinancialInstitutionIdentification9 AccountOwner { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification9 AccountOwner { get; init; } 
        #else
        public FinancialInstitutionIdentification9 AccountOwner { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
