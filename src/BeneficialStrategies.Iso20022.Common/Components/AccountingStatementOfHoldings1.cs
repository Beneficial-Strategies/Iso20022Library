// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an accounting statement of holdings.
/// </summary>
[IsoId("_UxD5R9p-Ed-ak6NoX_4Aeg_-1253958762")]
[DisplayName("Accounting Statement Of Holdings")]
public record AccountingStatementOfHoldings1
{
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_UxD5SNp-Ed-ak6NoX_4Aeg_-1253878902")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; }

    /// <summary>
    /// General information related to the custody statement of holdings that is being cancelled.
    /// </summary>
    [IsoId("_UxD5Sdp-Ed-ak6NoX_4Aeg_-127643593")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public Statement4? StatementGeneralDetails { get; init; }

    /// <summary>
    /// The safekeeping or investment account of the statement that is being cancelled.
    /// </summary>
    [IsoId("_UxD5Stp-Ed-ak6NoX_4Aeg_-29749859")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public SafekeepingAccount1? AccountDetails { get; init; }

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_UxNqQNp-Ed-ak6NoX_4Aeg_299025122")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public AggregateBalanceInformation2? BalanceForAccount { get; init; }

    /// <summary>
    /// The sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_UxNqQdp-Ed-ak6NoX_4Aeg_369211218")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccountIdentification2? SubAccountDetails { get; init; }

    /// <summary>
    /// Value of total holdings reported.
    /// </summary>
    [IsoId("_UxNqQtp-Ed-ak6NoX_4Aeg_454175646")]
    [DisplayName("Total Values")]
    [IsoXmlTag("TtlVals")]
    public TotalValueInPageAndStatement? TotalValues { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_UxNqQ9p-Ed-ak6NoX_4Aeg_-587709497")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
