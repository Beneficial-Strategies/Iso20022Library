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
[IsoId("_cPWbgdcZEeqRFcf2R4bPBw")]
[DisplayName("Cash Account Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccountCharacteristics4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashAccountCharacteristics4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashAccountCharacteristics4( AccountLevel2Code reqAccountLevel,CashAccount40 reqCashAccount,CompensationMethod1Code reqCompensationMethod,string reqAccountBalanceCurrencyCode,Contact4 reqAccountServicerContact )
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
    [IsoId("_cTJ9cdcZEeqRFcf2R4bPBw")]
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
    [IsoId("_cTJ9c9cZEeqRFcf2R4bPBw")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount40 CashAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount40 CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40 CashAccount { get; init; } 
    #else
    public CashAccount40 CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Usage: the account servicer is the domicile agent servicing the local account.
    /// </summary>
    [IsoId("_cTJ9ddcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Defines a parent account to which the cash account is related to.
    /// </summary>
    [IsoId("_cTJ9d9cZEeqRFcf2R4bPBw")]
    [DisplayName("Parent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrntAcct")]
    #endif
    [IsoXmlTag("PrntAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ParentCashAccount4? ParentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ParentCashAccount4? ParentAccount { get; init; } 
    #else
    public ParentCashAccount4? ParentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Defines if and how charges and taxes due are paid to the financial institution.
    /// </summary>
    [IsoId("_cTJ9edcZEeqRFcf2R4bPBw")]
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
    [IsoId("_cTJ9e9cZEeqRFcf2R4bPBw")]
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
    [IsoId("_cTJ9fdcZEeqRFcf2R4bPBw")]
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
    [IsoId("_cTJ9f9cZEeqRFcf2R4bPBw")]
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
    [IsoId("_cTJ9gdcZEeqRFcf2R4bPBw")]
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
    [IsoId("_cTJ9g9cZEeqRFcf2R4bPBw")]
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
    [IsoId("_cTJ9hdcZEeqRFcf2R4bPBw")]
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
    [IsoId("_cTJ9h9cZEeqRFcf2R4bPBw")]
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
    [IsoId("_cTJ9idcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Servicer Contact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcrCtct")]
    #endif
    [IsoXmlTag("AcctSvcrCtct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Contact4 AccountServicerContact { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Contact4 AccountServicerContact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contact4 AccountServicerContact { get; init; } 
    #else
    public Contact4 AccountServicerContact { get; set; } 
    #endif
    
    
    #nullable disable
    
}
