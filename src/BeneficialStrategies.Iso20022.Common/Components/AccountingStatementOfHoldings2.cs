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
[IsoId("_RPdawtp-Ed-ak6NoX_4Aeg_986842434")]
[DisplayName("Accounting Statement Of Holdings")]
public record AccountingStatementOfHoldings2
{
    /// <summary>
    /// General information related to the custody statement of holdings that is being cancelled.
    /// </summary>
    [IsoId("_RPdaw9p-Ed-ak6NoX_4Aeg_986842565")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public Statement6? StatementGeneralDetails { get; init; }

    /// <summary>
    /// The safekeeping or investment account of the statement that is being cancelled.
    /// </summary>
    [IsoId("_RPdaxNp-Ed-ak6NoX_4Aeg_986842453")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public SafekeepingAccount2? AccountDetails { get; init; }

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_RPdaxdp-Ed-ak6NoX_4Aeg_986842495")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public ValueList<AggregateBalanceInformation3> BalanceForAccount { get; init; } = [];

    /// <summary>
    /// The sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_RPdaxtp-Ed-ak6NoX_4Aeg_986842530")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public ValueList<SubAccountIdentification3> SubAccountDetails { get; init; } = [];

    /// <summary>
    /// Value of total holdings reported.
    /// </summary>
    [IsoId("_RPdax9p-Ed-ak6NoX_4Aeg_986842824")]
    [DisplayName("Total Values")]
    [IsoXmlTag("TtlVals")]
    public TotalValueInPageAndStatement? TotalValues { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RPdayNp-Ed-ak6NoX_4Aeg_986842867")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension1> Extension { get; init; } = [];
}
