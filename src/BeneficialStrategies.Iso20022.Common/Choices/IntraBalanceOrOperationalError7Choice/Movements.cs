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
namespace BeneficialStrategies.Iso20022.Choices.IntraBalanceOrOperationalError7Choice
{
    /// <summary>
    /// Identifies the transactions.
    /// </summary>
    [IsoId("_YDGlITneEem7JZMuWtwtsg")]
    [DisplayName("Movements")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Movements : IntraBalanceOrOperationalError7Choice_
    #else
    public partial class Movements : IntraBalanceOrOperationalError7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Account to or from which an entry is made.
        /// </summary>
        [IsoId("_YN1OeTneEem7JZMuWtwtsg")]
        [DisplayName("Cash Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CshAcct")]
        #endif
        [IsoXmlTag("CshAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccount38? CashAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount38? CashAccount { get; init; } 
        #else
        public CashAccount38? CashAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Party that owns the account.
        /// </summary>
        [IsoId("_YN1OdzneEem7JZMuWtwtsg")]
        [DisplayName("Cash Account Owner")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CshAcctOwnr")]
        #endif
        [IsoXmlTag("CshAcctOwnr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SystemPartyIdentification8? CashAccountOwner { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemPartyIdentification8? CashAccountOwner { get; init; } 
        #else
        public SystemPartyIdentification8? CashAccountOwner { get; set; } 
        #endif
        
        /// <summary>
        /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
        /// </summary>
        [IsoId("_lqm_kTqBEemJ3KLLPeYl6g")]
        [DisplayName("Cash Account Servicer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CshAcctSvcr")]
        #endif
        [IsoXmlTag("CshAcctSvcr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; set; } 
        #endif
        
        /// <summary>
        /// Status and status reason of the transaction.
        /// </summary>
        [IsoId("_YN1OezneEem7JZMuWtwtsg")]
        [DisplayName("Status And Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StsAndRsn")]
        #endif
        [IsoXmlTag("StsAndRsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IntraBalanceStatusAndReason2? StatusAndReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public IntraBalanceStatusAndReason2? StatusAndReason { get; init; } 
        #else
        public IntraBalanceStatusAndReason2? StatusAndReason { get; set; } 
        #endif
        
        /// <summary>
        /// Further details on the individual intrabalance movement transaction.
        /// </summary>
        [IsoId("_YN1OfTneEem7JZMuWtwtsg")]
        [DisplayName("Movement")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Mvmnt")]
        #endif
        [IsoXmlTag("Mvmnt")]
        public ValueList<IntraBalanceMovement5> Movement { get; init; } = new ValueList<IntraBalanceMovement5>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _YN1OfTneEem7JZMuWtwtsg
        
        
        #nullable disable
        
    }
}
