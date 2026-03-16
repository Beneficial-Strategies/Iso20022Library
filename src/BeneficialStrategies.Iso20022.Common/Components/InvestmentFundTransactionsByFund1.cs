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
[IsoId("_VGq85Np-Ed-ak6NoX_4Aeg_1018199129")]
[DisplayName("Investment Fund Transactions By Fund")]
public record InvestmentFundTransactionsByFund1
{
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_VGq85dp-Ed-ak6NoX_4Aeg_-117997473")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification1Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_VGq85tp-Ed-ak6NoX_4Aeg_-117997413")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    [IsoId("_VGq859p-Ed-ak6NoX_4Aeg_-117997361")]
    [DisplayName("Supplementary Identification")]
    [IsoXmlTag("SplmtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SupplementaryIdentification { get; init; }

    /// <summary>
    /// Specifies the form, ie, ownership, of the security.
    /// </summary>
    [IsoId("_VGq86Np-Ed-ak6NoX_4Aeg_-117997070")]
    [DisplayName("Form")]
    [IsoXmlTag("Form")]
    public FormOfSecurity1Code? Form { get; init; }

    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, eg, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_VGq86dp-Ed-ak6NoX_4Aeg_-117996940")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Income policy relating to a class type, ie, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_VGq86tp-Ed-ak6NoX_4Aeg_-117996855")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }

    /// <summary>
    /// Process of buying, selling, switching or transferring fund units.
    /// </summary>
    [IsoId("_VG0G0Np-Ed-ak6NoX_4Aeg_-3482322")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public ValueList<InvestmentFundTransaction2> TransactionDetails { get; init; } = [];

    // ID for the above is _VG0G0Np-Ed-ak6NoX_4Aeg_-3482322

    /// <summary>
    /// Balance of the financial instrument for this specific statement page.
    /// </summary>
    [IsoId("_VG0G0dp-Ed-ak6NoX_4Aeg_456431676")]
    [DisplayName("Balance By Page")]
    [IsoXmlTag("BalByPg")]
    public PaginationBalance1? BalanceByPage { get; init; }
}
