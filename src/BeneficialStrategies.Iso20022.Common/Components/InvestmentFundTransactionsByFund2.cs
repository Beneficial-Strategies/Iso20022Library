// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investment fund transactions for a specific financial instrument.
/// </summary>
[IsoId("_Scf1qNp-Ed-ak6NoX_4Aeg_-1907610515")]
[DisplayName("Investment Fund Transactions By Fund")]
public record InvestmentFundTransactionsByFund2
{
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_ScpmoNp-Ed-ak6NoX_4Aeg_-1907610498")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification3Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_Scpmodp-Ed-ak6NoX_4Aeg_-1907610480")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_Scpmotp-Ed-ak6NoX_4Aeg_-1907610455")]
    [DisplayName("Supplementary Identification")]
    [IsoXmlTag("SplmtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SupplementaryIdentification { get; init; }

    /// <summary>
    /// Form, ie, ownership, of the security, eg, registered or bearer.
    /// </summary>
    [IsoId("_Scpmo9p-Ed-ak6NoX_4Aeg_-1907610438")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, eg, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_ScpmpNp-Ed-ak6NoX_4Aeg_-1907610172")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Income policy relating to a class type, ie, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_Scpmpdp-Ed-ak6NoX_4Aeg_-1907610147")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }

    /// <summary>
    /// Process of buying, selling, switching or transferring fund units.
    /// </summary>
    [IsoId("_Scpmptp-Ed-ak6NoX_4Aeg_-1907610094")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public ValueList<InvestmentFundTransaction3> TransactionDetails { get; init; } = [];

    // ID for the above is _Scpmptp-Ed-ak6NoX_4Aeg_-1907610094

    /// <summary>
    /// Balance of the financial instrument for this specific statement page.
    /// </summary>
    [IsoId("_Scpmp9p-Ed-ak6NoX_4Aeg_-1907610129")]
    [DisplayName("Balance By Page")]
    [IsoXmlTag("BalByPg")]
    public PaginationBalance1? BalanceByPage { get; init; }
}
