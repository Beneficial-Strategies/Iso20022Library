// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a cash entry is made.
/// </summary>
[IsoId("_77E8gSCpEeWJd9HF2tO7BA")]
[DisplayName("Cash Account")]
public record CashAccount33
{
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    [IsoId("_SkLQUSCqEeWJd9HF2tO7BA")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public required ActiveCurrencyCode SettlementCurrency { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_8WdQ8SCpEeWJd9HF2tO7BA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentificationAndName5 Identification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_8WdQ8yCpEeWJd9HF2tO7BA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification70Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_8WdQ9SCpEeWJd9HF2tO7BA")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public FinancialInstitutionIdentification7Choice_? AccountServicer { get; init; }

    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    [IsoId("_8WdQ9yCpEeWJd9HF2tO7BA")]
    [DisplayName("Account Servicer Branch")]
    [IsoXmlTag("AcctSvcrBrnch")]
    public BranchData? AccountServicerBranch { get; init; }

    /// <summary>
    /// Alternative identification, for example, national registration identification number, passport number, tax identification number. This may be an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    [IsoId("_8WdQ-yCpEeWJd9HF2tO7BA")]
    [DisplayName("Account Owner Other Identification")]
    [IsoXmlTag("AcctOwnrOthrId")]
    public GenericIdentification82? AccountOwnerOtherIdentification { get; init; }

    /// <summary>
    /// Type of account.
    /// </summary>
    [IsoId("_8WdQ-SCpEeWJd9HF2tO7BA")]
    [DisplayName("Investment Account Type")]
    [IsoXmlTag("InvstmtAcctTp")]
    public AccountType2Choice_? InvestmentAccountType { get; init; }

    /// <summary>
    /// Specifies if the account is for credits or debits.
    /// </summary>
    [IsoId("_ApQGYCCrEeWJd9HF2tO7BA")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Type of transaction for which the cash account is specified.
    /// </summary>
    [IsoId("_WkDUUCCsEeWJd9HF2tO7BA")]
    [DisplayName("Settlement Instruction Reason")]
    [IsoXmlTag("SttlmInstrRsn")]
    public SettlementInstructionReason1Choice_? SettlementInstructionReason { get; init; }

    /// <summary>
    /// Purpose of the cash account.
    /// </summary>
    [IsoId("_KKhrgCCvEeWJd9HF2tO7BA")]
    [DisplayName("Cash Account Purpose")]
    [IsoXmlTag("CshAcctPurp")]
    public CashAccountType3Choice_? CashAccountPurpose { get; init; }

    /// <summary>
    /// Specifies whether the account is the primary or secondary account if there are two accounts for the same purpose.
    /// </summary>
    [IsoId("_eN4IQCCzEeWJd9HF2tO7BA")]
    [DisplayName("Cash Account Designation")]
    [IsoXmlTag("CshAcctDsgnt")]
    public AccountDesignation1Choice_? CashAccountDesignation { get; init; }

    /// <summary>
    /// Percentage of the dividend payment not to be reinvested, that is, to be paid in cash.
    /// </summary>
    [IsoId("_GasKcSC0EeWJd9HF2tO7BA")]
    [DisplayName("Dividend Percentage")]
    [IsoXmlTag("DvddPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageBoundedRate)]
    public IsoPercentageBoundedRate? DividendPercentage { get; init; }
}
