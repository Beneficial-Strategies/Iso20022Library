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
/// Specifies the characteristics of the cash account.
/// </summary>
[IsoId("_6RmCfpqlEeGSON8vddiWzQ_-1885901268")]
[DisplayName("Cash Account Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccountCharacteristics1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashAccountCharacteristics1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashAccountCharacteristics1( AccountLevel2Code reqAccountLevel,CashAccount16 reqCashAccount,CompensationMethod1Code reqCompensationMethod,string reqAccountBalanceCurrencyCode,ContactDetails3 reqAccountServicerContact )
    {
        AccountLevel = reqAccountLevel;
        CashAccount = reqCashAccount;
        CompensationMethod = reqCompensationMethod;
        AccountBalanceCurrencyCode = reqAccountBalanceCurrencyCode;
        AccountServicerContact = reqAccountServicerContact;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the account level within an account hierarchy.
    /// </summary>
    [IsoId("_6RvMYJqlEeGSON8vddiWzQ_598766931")]
    [DisplayName("Account Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctLvl")]
    #endif
    [IsoXmlTag("AcctLvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountLevel2Code AccountLevel { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountLevel2Code AccountLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountLevel2Code AccountLevel { get; init; } 
    #else
    public AccountLevel2Code AccountLevel { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_6RvMYZqlEeGSON8vddiWzQ_1529637333")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount16 CashAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount16 CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16 CashAccount { get; init; } 
    #else
    public CashAccount16 CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Usage: the account servicer is the domicile agent servicing the local account.
    /// </summary>
    [IsoId("_6RvMYpqlEeGSON8vddiWzQ_-1152772184")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Defines a parent account to which the cash account is related to.
    /// </summary>
    [IsoId("_6RvMY5qlEeGSON8vddiWzQ_-974653512")]
    [DisplayName("Parent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrntAcct")]
    #endif
    [IsoXmlTag("PrntAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ParentCashAccount1? ParentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ParentCashAccount1? ParentAccount { get; init; } 
    #else
    public ParentCashAccount1? ParentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Defines if and how charges and taxes due are paid to the financial institution.
    /// </summary>
    [IsoId("_6RvMZJqlEeGSON8vddiWzQ_-1838430112")]
    [DisplayName("Compensation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CompstnMtd")]
    #endif
    [IsoXmlTag("CompstnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CompensationMethod1Code CompensationMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CompensationMethod1Code CompensationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompensationMethod1Code CompensationMethod { get; init; } 
    #else
    public CompensationMethod1Code CompensationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the account debited for charges and taxes due on the cash account, if different from the cash account.
    /// </summary>
    [IsoId("_6RvMZZqlEeGSON8vddiWzQ_-193162677")]
    [DisplayName("Debit Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtAcct")]
    #endif
    [IsoXmlTag("DbtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? DebitAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? DebitAccount { get; init; } 
    #else
    public AccountIdentification4Choice_? DebitAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Future date on which the account will be automatically debited for charges and taxes due.
    /// </summary>
    [IsoId("_6RvMZpqlEeGSON8vddiWzQ_1345625765")]
    [DisplayName("Delayed Debit Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DelydDbtDt")]
    #endif
    [IsoXmlTag("DelydDbtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DelayedDebitDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DelayedDebitDate { get; init; } 
    #else
    public System.DateOnly? DelayedDebitDate { get; set; } 
    #endif
    
    /// <summary>
    /// Free form message advising the customer about the settlement of charges and taxes due.
    /// </summary>
    [IsoId("_6RvMZ5qlEeGSON8vddiWzQ_717549851")]
    [DisplayName("Settlement Advice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAdvc")]
    #endif
    [IsoXmlTag("SttlmAdvc")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? SettlementAdvice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SettlementAdvice { get; init; } 
    #else
    public System.String? SettlementAdvice { get; set; } 
    #endif
    
    /// <summary>
    /// Currency used to specify the account&apos;s balance currency.
    /// </summary>
    [IsoId("_6RvMaJqlEeGSON8vddiWzQ_-2069546215")]
    [DisplayName("Account Balance Currency Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctBalCcyCd")]
    #endif
    [IsoXmlTag("AcctBalCcyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode AccountBalanceCurrencyCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string AccountBalanceCurrencyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string AccountBalanceCurrencyCode { get; init; } 
    #else
    public string AccountBalanceCurrencyCode { get; set; } 
    #endif
    
    /// <summary>
    /// Currency used to specify the account&apos;s settlement currency.
    /// </summary>
    [IsoId("_6R49YJqlEeGSON8vddiWzQ_-424278780")]
    [DisplayName("Settlement Currency Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcyCd")]
    #endif
    [IsoXmlTag("SttlmCcyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? SettlementCurrencyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SettlementCurrencyCode { get; init; } 
    #else
    public string? SettlementCurrencyCode { get; set; } 
    #endif
    
    /// <summary>
    /// Currency used to specify the account&apos;s taxing host currency.
    /// </summary>
    [IsoId("_6R49YZqlEeGSON8vddiWzQ_1114509662")]
    [DisplayName("Host Currency Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstCcyCd")]
    #endif
    [IsoXmlTag("HstCcyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? HostCurrencyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? HostCurrencyCode { get; init; } 
    #else
    public string? HostCurrencyCode { get; set; } 
    #endif
    
    /// <summary>
    /// Describes account taxing parameters.
    /// </summary>
    [IsoId("_6R49YpqlEeGSON8vddiWzQ_409395047")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountTax1? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountTax1? Tax { get; init; } 
    #else
    public AccountTax1? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Individual to contact at the financial institution&apos;s location regarding problems of a business nature.
    /// </summary>
    [IsoId("_6R49Y5qlEeGSON8vddiWzQ_2106192736")]
    [DisplayName("Account Servicer Contact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrCtct")]
    #endif
    [IsoXmlTag("AcctSvcrCtct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContactDetails3 AccountServicerContact { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContactDetails3 AccountServicerContact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactDetails3 AccountServicerContact { get; init; } 
    #else
    public ContactDetails3 AccountServicerContact { get; set; } 
    #endif
    
    
    #nullable disable
    
}
