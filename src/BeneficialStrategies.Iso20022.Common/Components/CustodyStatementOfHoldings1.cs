// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a custody statement of holdings.
/// </summary>
[IsoId("_UyjHA9p-Ed-ak6NoX_4Aeg_-1254942072")]
[DisplayName("Custody Statement Of Holdings")]
public record CustodyStatementOfHoldings1
{
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_UyjHBNp-Ed-ak6NoX_4Aeg_-1242798695")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; }

    /// <summary>
    /// General information related to the custody statement of holdings that is being cancelled.
    /// </summary>
    [IsoId("_UyjHBdp-Ed-ak6NoX_4Aeg_488546587")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public Statement3? StatementGeneralDetails { get; init; }

    /// <summary>
    /// Safekeeping or investment account of the statement that is being cancelled.
    /// </summary>
    [IsoId("_UyjHBtp-Ed-ak6NoX_4Aeg_612299942")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public SafekeepingAccount1? AccountDetails { get; init; }

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_UyjHB9p-Ed-ak6NoX_4Aeg_-972729362")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public AggregateBalanceInformation1? BalanceForAccount { get; init; }

    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_UyjHCNp-Ed-ak6NoX_4Aeg_-789871364")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccountIdentification1? SubAccountDetails { get; init; }

    /// <summary>
    /// Value of total holdings reported.
    /// </summary>
    [IsoId("_Uys4ANp-Ed-ak6NoX_4Aeg_-414920301")]
    [DisplayName("Total Values")]
    [IsoXmlTag("TtlVals")]
    public TotalValueInPageAndStatement? TotalValues { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Uys4Adp-Ed-ak6NoX_4Aeg_46750019")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
