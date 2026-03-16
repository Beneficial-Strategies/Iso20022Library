// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a statement of investment fund transactions.
/// </summary>
[IsoId("_w0igYQf7EeSNB7vR9dc0nw")]
[DisplayName("Statement Of Investment Fund Transactions")]
public record StatementOfInvestmentFundTransactions3
{
    /// <summary>
    /// General information related to the investment fund statement of transactions that is being cancelled.
    /// </summary>
    [IsoId("_xQD-xQf7EeSNB7vR9dc0nw")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public Statement8? StatementGeneralDetails { get; init; }

    /// <summary>
    /// Information related to an investment account of the statement that is being cancelled.
    /// </summary>
    [IsoId("_xQD-xwf7EeSNB7vR9dc0nw")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount43? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
    /// </summary>
    [IsoId("_xQD-yQf7EeSNB7vR9dc0nw")]
    [DisplayName("Transaction On Account")]
    [IsoXmlTag("TxOnAcct")]
    public InvestmentFundTransactionsByFund3? TransactionOnAccount { get; init; }

    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_xQD-ywf7EeSNB7vR9dc0nw")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccountIdentification36? SubAccountDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_xQD-zQf7EeSNB7vR9dc0nw")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
