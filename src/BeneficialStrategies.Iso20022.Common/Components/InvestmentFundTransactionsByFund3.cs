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
[IsoId("_3ZqIWwf9EeSaceXTzyiZRg")]
[DisplayName("Investment Fund Transactions By Fund")]
public record InvestmentFundTransactionsByFund3
{
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_3zPtAwf9EeSaceXTzyiZRg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification3Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_3zPtBQf9EeSaceXTzyiZRg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_3zPtBwf9EeSaceXTzyiZRg")]
    [DisplayName("Supplementary Identification")]
    [IsoXmlTag("SplmtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SupplementaryIdentification { get; init; }

    /// <summary>
    /// Form, that is, ownership, of the security, for example, registered or bearer.
    /// </summary>
    [IsoId("_3zPtCQf9EeSaceXTzyiZRg")]
    [DisplayName("Securities Form")]
    [IsoXmlTag("SctiesForm")]
    public FormOfSecurity1Code? SecuritiesForm { get; init; }

    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_3zPtEQf9EeSaceXTzyiZRg")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Income policy relating to a class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_3zPtEwf9EeSaceXTzyiZRg")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }

    /// <summary>
    /// Process of buying, selling, switching or transferring fund units.
    /// </summary>
    [IsoId("_3zPtFQf9EeSaceXTzyiZRg")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public ValueList<InvestmentFundTransaction4> TransactionDetails { get; init; } = [];

    // ID for the above is _3zPtFQf9EeSaceXTzyiZRg

    /// <summary>
    /// Balance of the financial instrument for this specific statement page.
    /// </summary>
    [IsoId("_3zPtFwf9EeSaceXTzyiZRg")]
    [DisplayName("Balance By Page")]
    [IsoXmlTag("BalByPg")]
    public PaginationBalance2? BalanceByPage { get; init; }
}
