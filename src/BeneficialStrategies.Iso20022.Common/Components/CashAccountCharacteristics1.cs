// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the characteristics of the cash account.
/// </summary>
[IsoId("_6RmCfpqlEeGSON8vddiWzQ_-1885901268")]
[DisplayName("Cash Account Characteristics")]
public record CashAccountCharacteristics1
{
    /// <summary>
    /// Defines the account level within an account hierarchy.
    /// </summary>
    [IsoId("_6RvMYJqlEeGSON8vddiWzQ_598766931")]
    [DisplayName("Account Level")]
    [IsoXmlTag("AcctLvl")]
    public required AccountLevel2Code AccountLevel { get; init; }

    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_6RvMYZqlEeGSON8vddiWzQ_1529637333")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public required CashAccount16 CashAccount { get; init; }

    /// <summary>
    /// Usage: the account servicer is the domicile agent servicing the local account.
    /// </summary>
    [IsoId("_6RvMYpqlEeGSON8vddiWzQ_-1152772184")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; }

    /// <summary>
    /// Defines a parent account to which the cash account is related to.
    /// </summary>
    [IsoId("_6RvMY5qlEeGSON8vddiWzQ_-974653512")]
    [DisplayName("Parent Account")]
    [IsoXmlTag("PrntAcct")]
    public ParentCashAccount1? ParentAccount { get; init; }

    /// <summary>
    /// Defines if and how charges and taxes due are paid to the financial institution.
    /// </summary>
    [IsoId("_6RvMZJqlEeGSON8vddiWzQ_-1838430112")]
    [DisplayName("Compensation Method")]
    [IsoXmlTag("CompstnMtd")]
    public required CompensationMethod1Code CompensationMethod { get; init; }

    /// <summary>
    /// Defines the account debited for charges and taxes due on the cash account, if different from the cash account.
    /// </summary>
    [IsoId("_6RvMZZqlEeGSON8vddiWzQ_-193162677")]
    [DisplayName("Debit Account")]
    [IsoXmlTag("DbtAcct")]
    public AccountIdentification4Choice_? DebitAccount { get; init; }

    /// <summary>
    /// Future date on which the account will be automatically debited for charges and taxes due.
    /// </summary>
    [IsoId("_6RvMZpqlEeGSON8vddiWzQ_1345625765")]
    [DisplayName("Delayed Debit Date")]
    [IsoXmlTag("DelydDbtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DelayedDebitDate { get; init; }

    /// <summary>
    /// Free form message advising the customer about the settlement of charges and taxes due.
    /// </summary>
    [IsoId("_6RvMZ5qlEeGSON8vddiWzQ_717549851")]
    [DisplayName("Settlement Advice")]
    [IsoXmlTag("SttlmAdvc")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? SettlementAdvice { get; init; }

    /// <summary>
    /// Currency used to specify the account&apos;s balance currency.
    /// </summary>
    [IsoId("_6RvMaJqlEeGSON8vddiWzQ_-2069546215")]
    [DisplayName("Account Balance Currency Code")]
    [IsoXmlTag("AcctBalCcyCd")]
    public required ActiveOrHistoricCurrencyCode AccountBalanceCurrencyCode { get; init; }

    /// <summary>
    /// Currency used to specify the account&apos;s settlement currency.
    /// </summary>
    [IsoId("_6R49YJqlEeGSON8vddiWzQ_-424278780")]
    [DisplayName("Settlement Currency Code")]
    [IsoXmlTag("SttlmCcyCd")]
    public ActiveOrHistoricCurrencyCode? SettlementCurrencyCode { get; init; }

    /// <summary>
    /// Currency used to specify the account&apos;s taxing host currency.
    /// </summary>
    [IsoId("_6R49YZqlEeGSON8vddiWzQ_1114509662")]
    [DisplayName("Host Currency Code")]
    [IsoXmlTag("HstCcyCd")]
    public ActiveOrHistoricCurrencyCode? HostCurrencyCode { get; init; }

    /// <summary>
    /// Describes account taxing parameters.
    /// </summary>
    [IsoId("_6R49YpqlEeGSON8vddiWzQ_409395047")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public AccountTax1? Tax { get; init; }

    /// <summary>
    /// Individual to contact at the financial institution&apos;s location regarding problems of a business nature.
    /// </summary>
    [IsoId("_6R49Y5qlEeGSON8vddiWzQ_2106192736")]
    [DisplayName("Account Servicer Contact")]
    [IsoXmlTag("AcctSvcrCtct")]
    public required ContactDetails3 AccountServicerContact { get; init; }
}
