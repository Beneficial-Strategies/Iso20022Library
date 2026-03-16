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
[IsoId("_U2krYNp-Ed-ak6NoX_4Aeg_1424253677")]
[DisplayName("Statement Of Investment Fund Transactions")]
public record StatementOfInvestmentFundTransactions1
{
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_U2krYdp-Ed-ak6NoX_4Aeg_366794221")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; }

    /// <summary>
    /// General information related to the investment fund statement of transactions that is being cancelled.
    /// </summary>
    [IsoId("_U2krYtp-Ed-ak6NoX_4Aeg_1826589543")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public Statement5? StatementGeneralDetails { get; init; }

    /// <summary>
    /// Information related to an investment account of the statement that is being cancelled.
    /// </summary>
    [IsoId("_U2krY9p-Ed-ak6NoX_4Aeg_2103646761")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount12? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
    /// </summary>
    [IsoId("_U2krZNp-Ed-ak6NoX_4Aeg_-2082346451")]
    [DisplayName("Transaction On Account")]
    [IsoXmlTag("TxOnAcct")]
    public InvestmentFundTransactionsByFund1? TransactionOnAccount { get; init; }

    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_U2krZdp-Ed-ak6NoX_4Aeg_-1749876008")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public required SubAccountIdentification4 SubAccountDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_U2krZtp-Ed-ak6NoX_4Aeg_730156025")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
