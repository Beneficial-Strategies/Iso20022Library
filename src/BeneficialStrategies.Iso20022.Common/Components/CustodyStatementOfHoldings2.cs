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
[IsoId("_RPKf0tp-Ed-ak6NoX_4Aeg_1115213683")]
[DisplayName("Custody Statement Of Holdings")]
public record CustodyStatementOfHoldings2
{
    /// <summary>
    /// General information related to the custody statement of holdings that is being cancelled.
    /// </summary>
    [IsoId("_RPKf09p-Ed-ak6NoX_4Aeg_1115213702")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public Statement7? StatementGeneralDetails { get; init; }

    /// <summary>
    /// Safekeeping or investment account of the statement that is being cancelled.
    /// </summary>
    [IsoId("_RPKf1Np-Ed-ak6NoX_4Aeg_1115213839")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public SafekeepingAccount2? AccountDetails { get; init; }

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_RPKf1dp-Ed-ak6NoX_4Aeg_1115213779")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public ValueList<AggregateBalanceInformation4> BalanceForAccount { get; init; } = [];

    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_RPKf1tp-Ed-ak6NoX_4Aeg_1115213821")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public ValueList<SubAccountIdentification5> SubAccountDetails { get; init; } = [];

    /// <summary>
    /// Value of total holdings reported.
    /// </summary>
    [IsoId("_RPKf19p-Ed-ak6NoX_4Aeg_1115213744")]
    [DisplayName("Total Values")]
    [IsoXmlTag("TtlVals")]
    public TotalValueInPageAndStatement? TotalValues { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RPKf2Np-Ed-ak6NoX_4Aeg_1115213874")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension1> Extension { get; init; } = [];
}
