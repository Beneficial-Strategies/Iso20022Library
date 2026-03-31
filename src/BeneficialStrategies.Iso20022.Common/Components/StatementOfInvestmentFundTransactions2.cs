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
[IsoId("_ROHW-tp-Ed-ak6NoX_4Aeg_-1658317001")]
[DisplayName("Statement Of Investment Fund Transactions")]
public record StatementOfInvestmentFundTransactions2
{
    /// <summary>
    /// General information related to the investment fund statement of transactions that is being cancelled.
    /// </summary>
    [IsoId("_ROHW-9p-Ed-ak6NoX_4Aeg_-1658316838")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public Statement8? StatementGeneralDetails { get; init; }

    /// <summary>
    /// Information related to an investment account of the statement that is being cancelled.
    /// </summary>
    [IsoId("_ROHW_Np-Ed-ak6NoX_4Aeg_-1658316880")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount25? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
    /// </summary>
    [IsoId("_RORH8Np-Ed-ak6NoX_4Aeg_-1658316898")]
    [DisplayName("Transaction On Account")]
    [IsoXmlTag("TxOnAcct")]
    public ValueList<InvestmentFundTransactionsByFund2> TransactionOnAccount { get; init; } = [];

    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_RORH8dp-Ed-ak6NoX_4Aeg_-1658316940")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public required SubAccountIdentification6 SubAccountDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RORH8tp-Ed-ak6NoX_4Aeg_-1658316820")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension1> Extension { get; init; } = [];
}
