// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash Account Characteristics5.
/// </summary>
[IsoId("_xf3iYTEyEe6g-ffJsqGiSA")]
[DisplayName("Cash Account Characteristics5")]
public record CashAccountCharacteristics5
{
    /// <summary>
    /// Account Balance Currency Code.
    /// </summary>
    [DisplayName("Account Balance Currency Code")]
    [IsoXmlTag("AcctBalCcyCd")]
    public required ActiveOrHistoricCurrencyCode AccountBalanceCurrencyCode { get; init; }

    /// <summary>
    /// Account Level.
    /// </summary>
    [DisplayName("Account Level")]
    [IsoXmlTag("AcctLvl")]
    public required AccountLevel2Code AccountLevel { get; init; }

    /// <summary>
    /// Account Servicer.
    /// </summary>
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? AccountServicer { get; init; }

    /// <summary>
    /// Account Servicer Contact.
    /// </summary>
    [DisplayName("Account Servicer Contact")]
    [IsoXmlTag("AcctSvcrCtct")]
    public required Contact13 AccountServicerContact { get; init; }

    /// <summary>
    /// Cash Account.
    /// </summary>
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public required CashAccount40 CashAccount { get; init; }

    /// <summary>
    /// Compensation Method.
    /// </summary>
    [DisplayName("Compensation Method")]
    [IsoXmlTag("CompstnMtd")]
    public required CompensationMethod1Code CompensationMethod { get; init; }

    /// <summary>
    /// Debit Account.
    /// </summary>
    [DisplayName("Debit Account")]
    [IsoXmlTag("DbtAcct")]
    public AccountIdentification4Choice_? DebitAccount { get; init; }

    /// <summary>
    /// Delayed Debit Date.
    /// </summary>
    [DisplayName("Delayed Debit Date")]
    [IsoXmlTag("DelydDbtDt")]
    public IsoISODate? DelayedDebitDate { get; init; }

    /// <summary>
    /// Host Currency Code.
    /// </summary>
    [DisplayName("Host Currency Code")]
    [IsoXmlTag("HstCcyCd")]
    public ActiveOrHistoricCurrencyCode? HostCurrencyCode { get; init; }

    /// <summary>
    /// Parent Account.
    /// </summary>
    [DisplayName("Parent Account")]
    [IsoXmlTag("PrntAcct")]
    public ParentCashAccount5? ParentAccount { get; init; }

    /// <summary>
    /// Settlement Advice.
    /// </summary>
    [DisplayName("Settlement Advice")]
    [IsoXmlTag("SttlmAdvc")]
    public IsoMax105Text? SettlementAdvice { get; init; }

    /// <summary>
    /// Settlement Currency Code.
    /// </summary>
    [DisplayName("Settlement Currency Code")]
    [IsoXmlTag("SttlmCcyCd")]
    public ActiveOrHistoricCurrencyCode? SettlementCurrencyCode { get; init; }

    /// <summary>
    /// Tax.
    /// </summary>
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public AccountTax1? Tax { get; init; }
}
