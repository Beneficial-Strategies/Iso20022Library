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
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll3Choice
{
    /// <summary>
    /// Identification of single standing orders defined with specific characteristics.
    /// </summary>
    [IsoId("_ex1mYdcZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record StandingOrder : StandingOrderOrAll3Choice_
    #else
    public partial class StandingOrder : StandingOrderOrAll3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a StandingOrder instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public StandingOrder( CashAccount40 reqAccount )
        {
            Account = reqAccount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
        /// </summary>
        [IsoId("_bTVfMdcZEeqRFcf2R4bPBw")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Identification { get; init; } 
        #else
        public System.String? Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
        /// </summary>
        [IsoId("_bTVfM9cZEeqRFcf2R4bPBw")]
        [DisplayName("Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Acct")]
        #endif
        [IsoXmlTag("Acct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CashAccount40 Account { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CashAccount40 Account { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount40 Account { get; init; } 
        #else
        public CashAccount40 Account { get; set; } 
        #endif
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_bTVfNdcZEeqRFcf2R4bPBw")]
        [DisplayName("Account Owner")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctOwnr")]
        #endif
        [IsoXmlTag("AcctOwnr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
