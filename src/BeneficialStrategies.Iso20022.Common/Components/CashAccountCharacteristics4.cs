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
[IsoId("_cPWbgdcZEeqRFcf2R4bPBw")]
[DisplayName("Cash Account Characteristics")]
public partial record CashAccountCharacteristics4
{
    #nullable enable
    
    /// <summary>
    /// Defines the account level within an account hierarchy.
    /// </summary>
    [IsoId("_cTJ9cdcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Level")]
    [IsoXmlTag("AcctLvl")]
    public required AccountLevel2Code AccountLevel { get; init; } 
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_cTJ9c9cZEeqRFcf2R4bPBw")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public required CashAccount40 CashAccount { get; init; } 
    
    /// <summary>
    /// Usage: the account servicer is the domicile agent servicing the local account.
    /// </summary>
    [IsoId("_cTJ9ddcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; } 
    
    /// <summary>
    /// Defines a parent account to which the cash account is related to.
    /// </summary>
    [IsoId("_cTJ9d9cZEeqRFcf2R4bPBw")]
    [DisplayName("Parent Account")]
    [IsoXmlTag("PrntAcct")]
    public ParentCashAccount4? ParentAccount { get; init; } 
    
    /// <summary>
    /// Defines if and how charges and taxes due are paid to the financial institution.
    /// </summary>
    [IsoId("_cTJ9edcZEeqRFcf2R4bPBw")]
    [DisplayName("Compensation Method")]
    [IsoXmlTag("CompstnMtd")]
    public required CompensationMethod1Code CompensationMethod { get; init; } 
    
    /// <summary>
    /// Defines the account debited for charges and taxes due on the cash account, if different from the cash account.
    /// </summary>
    [IsoId("_cTJ9e9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debit Account")]
    [IsoXmlTag("DbtAcct")]
    public AccountIdentification4Choice_? DebitAccount { get; init; } 
    
    /// <summary>
    /// Future date on which the account will be automatically debited for charges and taxes due.
    /// </summary>
    [IsoId("_cTJ9fdcZEeqRFcf2R4bPBw")]
    [DisplayName("Delayed Debit Date")]
    [IsoXmlTag("DelydDbtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DelayedDebitDate { get; init; } 
    
    /// <summary>
    /// Free form message advising the customer about the settlement of charges and taxes due.
    /// </summary>
    [IsoId("_cTJ9f9cZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Advice")]
    [IsoXmlTag("SttlmAdvc")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? SettlementAdvice { get; init; } 
    
    /// <summary>
    /// Currency used to specify the account&apos;s balance currency.
    /// </summary>
    [IsoId("_cTJ9gdcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Balance Currency Code")]
    [IsoXmlTag("AcctBalCcyCd")]
    public required ActiveOrHistoricCurrencyCode AccountBalanceCurrencyCode { get; init; } 
    
    /// <summary>
    /// Currency used to specify the account&apos;s settlement currency.
    /// </summary>
    [IsoId("_cTJ9g9cZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Currency Code")]
    [IsoXmlTag("SttlmCcyCd")]
    public ActiveOrHistoricCurrencyCode? SettlementCurrencyCode { get; init; } 
    
    /// <summary>
    /// Currency used to specify the account&apos;s taxing host currency.
    /// </summary>
    [IsoId("_cTJ9hdcZEeqRFcf2R4bPBw")]
    [DisplayName("Host Currency Code")]
    [IsoXmlTag("HstCcyCd")]
    public ActiveOrHistoricCurrencyCode? HostCurrencyCode { get; init; } 
    
    /// <summary>
    /// Describes account taxing parameters.
    /// </summary>
    [IsoId("_cTJ9h9cZEeqRFcf2R4bPBw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public AccountTax1? Tax { get; init; } 
    
    /// <summary>
    /// Individual to contact at the financial institution&apos;s location regarding problems of a business nature.
    /// </summary>
    [IsoId("_cTJ9idcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Servicer Contact")]
    [IsoXmlTag("AcctSvcrCtct")]
    public required Contact4 AccountServicerContact { get; init; } 
    
    
    #nullable disable
    
}
