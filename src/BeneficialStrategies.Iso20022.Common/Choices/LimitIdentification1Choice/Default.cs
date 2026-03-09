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
namespace BeneficialStrategies.Iso20022.Choices.LimitIdentification1Choice
{
    /// <summary>
    /// Identification of the default limit.
    /// </summary>
    [IsoId("_73kl0aMgEeCJ6YNENx4h-w_-1732988823")]
    [DisplayName("Default")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Default : LimitIdentification1Choice_
    #else
    public partial class Default : LimitIdentification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Default instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Default( LimitType1Choice_ reqType )
        {
            Type = reqType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of a particular cash clearing system.
        /// </summary>
        [IsoId("_79PI8qMgEeCJ6YNENx4h-w_1960983168")]
        [DisplayName("System Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SysId")]
        #endif
        [IsoXmlTag("SysId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SystemIdentification2Choice_? SystemIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemIdentification2Choice_? SystemIdentification { get; init; } 
        #else
        public SystemIdentification2Choice_? SystemIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the system member for which the limit is established.
        /// </summary>
        [IsoId("_79PI86MgEeCJ6YNENx4h-w_-340171683")]
        [DisplayName("Bilateral Limit Counterparty Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BilLmtCtrPtyId")]
        #endif
        [IsoXmlTag("BilLmtCtrPtyId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification5? BilateralLimitCounterpartyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification5? BilateralLimitCounterpartyIdentification { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification5? BilateralLimitCounterpartyIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Nature of the risk management limit.
        /// </summary>
        [IsoId("_79PI9KMgEeCJ6YNENx4h-w_200278245")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required LimitType1Choice_ Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required LimitType1Choice_ Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public LimitType1Choice_ Type { get; init; } 
        #else
        public LimitType1Choice_ Type { get; set; } 
        #endif
        
        /// <summary>
        /// Owner of the account which is being queried.
        /// </summary>
        [IsoId("_79PI9aMgEeCJ6YNENx4h-w_688763835")]
        [DisplayName("Account Owner")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctOwnr")]
        #endif
        [IsoXmlTag("AcctOwnr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_79PI9qMgEeCJ6YNENx4h-w_878107001")]
        [DisplayName("Account Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctId")]
        #endif
        [IsoXmlTag("AcctId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentification4Choice_? AccountIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentification4Choice_? AccountIdentification { get; init; } 
        #else
        public AccountIdentification4Choice_? AccountIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
