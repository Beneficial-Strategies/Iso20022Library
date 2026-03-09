// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a cash entry is made.
/// </summary>
[IsoId("_77E8gSCpEeWJd9HF2tO7BA")]
[DisplayName("Cash Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccount33
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashAccount33 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashAccount33( string reqSettlementCurrency,AccountIdentificationAndName5 reqIdentification )
    {
        SettlementCurrency = reqSettlementCurrency;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    [IsoId("_SkLQUSCqEeWJd9HF2tO7BA")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode SettlementCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string SettlementCurrency { get; init; } 
    #else
    public string SettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_8WdQ8SCpEeWJd9HF2tO7BA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentificationAndName5 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentificationAndName5 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentificationAndName5 Identification { get; init; } 
    #else
    public AccountIdentificationAndName5 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_8WdQ8yCpEeWJd9HF2tO7BA")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification70Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification70Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification70Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_8WdQ9SCpEeWJd9HF2tO7BA")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstitutionIdentification7Choice_? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification7Choice_? AccountServicer { get; init; } 
    #else
    public FinancialInstitutionIdentification7Choice_? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    [IsoId("_8WdQ9yCpEeWJd9HF2tO7BA")]
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
    /// Alternative identification, for example, national registration identification number, passport number, tax identification number. This may be an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    [IsoId("_8WdQ-yCpEeWJd9HF2tO7BA")]
    [DisplayName("Account Owner Other Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnrOthrId")]
    #endif
    [IsoXmlTag("AcctOwnrOthrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification82? AccountOwnerOtherIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification82? AccountOwnerOtherIdentification { get; init; } 
    #else
    public GenericIdentification82? AccountOwnerOtherIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of account.
    /// </summary>
    [IsoId("_8WdQ-SCpEeWJd9HF2tO7BA")]
    [DisplayName("Investment Account Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctTp")]
    #endif
    [IsoXmlTag("InvstmtAcctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountType2Choice_? InvestmentAccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountType2Choice_? InvestmentAccountType { get; init; } 
    #else
    public AccountType2Choice_? InvestmentAccountType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the account is for credits or debits.
    /// </summary>
    [IsoId("_ApQGYCCrEeWJd9HF2tO7BA")]
    [DisplayName("Credit Debit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbt")]
    #endif
    [IsoXmlTag("CdtDbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebit3Code? CreditDebit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebit3Code? CreditDebit { get; init; } 
    #else
    public CreditDebit3Code? CreditDebit { get; set; } 
    #endif
    
    /// <summary>
    /// Type of transaction for which the cash account is specified.
    /// </summary>
    [IsoId("_WkDUUCCsEeWJd9HF2tO7BA")]
    [DisplayName("Settlement Instruction Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmInstrRsn")]
    #endif
    [IsoXmlTag("SttlmInstrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementInstructionReason1Choice_? SettlementInstructionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementInstructionReason1Choice_? SettlementInstructionReason { get; init; } 
    #else
    public SettlementInstructionReason1Choice_? SettlementInstructionReason { get; set; } 
    #endif
    
    /// <summary>
    /// Purpose of the cash account.
    /// </summary>
    [IsoId("_KKhrgCCvEeWJd9HF2tO7BA")]
    [DisplayName("Cash Account Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctPurp")]
    #endif
    [IsoXmlTag("CshAcctPurp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountType3Choice_? CashAccountPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountType3Choice_? CashAccountPurpose { get; init; } 
    #else
    public CashAccountType3Choice_? CashAccountPurpose { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the account is the primary or secondary account if there are two accounts for the same purpose.
    /// </summary>
    [IsoId("_eN4IQCCzEeWJd9HF2tO7BA")]
    [DisplayName("Cash Account Designation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctDsgnt")]
    #endif
    [IsoXmlTag("CshAcctDsgnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountDesignation1Choice_? CashAccountDesignation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountDesignation1Choice_? CashAccountDesignation { get; init; } 
    #else
    public AccountDesignation1Choice_? CashAccountDesignation { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the dividend payment not to be reinvested, that is, to be paid in cash.
    /// </summary>
    [IsoId("_GasKcSC0EeWJd9HF2tO7BA")]
    [DisplayName("Dividend Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddPctg")]
    #endif
    [IsoXmlTag("DvddPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageBoundedRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageBoundedRate? DividendPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? DividendPercentage { get; init; } 
    #else
    public System.Decimal? DividendPercentage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
