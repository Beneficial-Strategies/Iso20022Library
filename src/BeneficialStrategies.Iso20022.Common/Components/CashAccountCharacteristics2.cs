// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the characteristics of the cash account.
/// </summary>
[IsoId("_E2cgoTq3EeWZFYSPlduMhw")]
[DisplayName("Cash Account Characteristics")]
public partial record CashAccountCharacteristics2
{
    #nullable enable
    
    /// <summary>
    /// Defines the account level within an account hierarchy.
    /// </summary>
    [IsoId("_E9mRgTq3EeWZFYSPlduMhw")]
    [DisplayName("Account Level")]
    [IsoXmlTag("AcctLvl")]
    public required AccountLevel2Code AccountLevel { get; init; } 
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_E9mRgzq3EeWZFYSPlduMhw")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public required CashAccount24 CashAccount { get; init; } 
    
    /// <summary>
    /// Usage: the account servicer is the domicile agent servicing the local account.
    /// </summary>
    [IsoId("_E9mRhTq3EeWZFYSPlduMhw")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; } 
    
    /// <summary>
    /// Defines a parent account to which the cash account is related to.
    /// </summary>
    [IsoId("_E9mRhzq3EeWZFYSPlduMhw")]
    [DisplayName("Parent Account")]
    [IsoXmlTag("PrntAcct")]
    public ParentCashAccount2? ParentAccount { get; init; } 
    
    /// <summary>
    /// Defines if and how charges and taxes due are paid to the financial institution.
    /// </summary>
    [IsoId("_E9mRiTq3EeWZFYSPlduMhw")]
    [DisplayName("Compensation Method")]
    [IsoXmlTag("CompstnMtd")]
    public required CompensationMethod1Code CompensationMethod { get; init; } 
    
    /// <summary>
    /// Defines the account debited for charges and taxes due on the cash account, if different from the cash account.
    /// </summary>
    [IsoId("_E9mRizq3EeWZFYSPlduMhw")]
    [DisplayName("Debit Account")]
    [IsoXmlTag("DbtAcct")]
    public AccountIdentification4Choice_? DebitAccount { get; init; } 
    
    /// <summary>
    /// Future date on which the account will be automatically debited for charges and taxes due.
    /// </summary>
    [IsoId("_E9mRjTq3EeWZFYSPlduMhw")]
    [DisplayName("Delayed Debit Date")]
    [IsoXmlTag("DelydDbtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DelayedDebitDate { get; init; } 
    
    /// <summary>
    /// Free form message advising the customer about the settlement of charges and taxes due.
    /// </summary>
    [IsoId("_E9mRjzq3EeWZFYSPlduMhw")]
    [DisplayName("Settlement Advice")]
    [IsoXmlTag("SttlmAdvc")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? SettlementAdvice { get; init; } 
    
    /// <summary>
    /// Currency used to specify the account&apos;s balance currency.
    /// </summary>
    [IsoId("_E9mRkTq3EeWZFYSPlduMhw")]
    [DisplayName("Account Balance Currency Code")]
    [IsoXmlTag("AcctBalCcyCd")]
    public required ActiveOrHistoricCurrencyCode AccountBalanceCurrencyCode { get; init; } 
    
    /// <summary>
    /// Currency used to specify the account&apos;s settlement currency.
    /// </summary>
    [IsoId("_E9mRkzq3EeWZFYSPlduMhw")]
    [DisplayName("Settlement Currency Code")]
    [IsoXmlTag("SttlmCcyCd")]
    public ActiveOrHistoricCurrencyCode? SettlementCurrencyCode { get; init; } 
    
    /// <summary>
    /// Currency used to specify the account&apos;s taxing host currency.
    /// </summary>
    [IsoId("_E9mRlTq3EeWZFYSPlduMhw")]
    [DisplayName("Host Currency Code")]
    [IsoXmlTag("HstCcyCd")]
    public ActiveOrHistoricCurrencyCode? HostCurrencyCode { get; init; } 
    
    /// <summary>
    /// Describes account taxing parameters.
    /// </summary>
    [IsoId("_E9mRlzq3EeWZFYSPlduMhw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public AccountTax1? Tax { get; init; } 
    
    /// <summary>
    /// Individual to contact at the financial institution&apos;s location regarding problems of a business nature.
    /// </summary>
    [IsoId("_E9mRmTq3EeWZFYSPlduMhw")]
    [DisplayName("Account Servicer Contact")]
    [IsoXmlTag("AcctSvcrCtct")]
    public required ContactDetails3 AccountServicerContact { get; init; } 
    
    
    #nullable disable
    
}
