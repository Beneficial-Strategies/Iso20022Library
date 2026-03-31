// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Period16.
/// </summary>
[IsoId("_YUyysX_7Ee-O2vOutgwfsA")]
[DisplayName("Corporate Action Period16")]
public record CorporateActionPeriod16
{
    /// <summary>
    /// Book Closure Period.
    /// </summary>
    [DisplayName("Book Closure Period")]
    [IsoXmlTag("BookClsrPrd")]
    public Period6Choice_? BookClosurePeriod { get; init; }

    /// <summary>
    /// Claim Period.
    /// </summary>
    [DisplayName("Claim Period")]
    [IsoXmlTag("ClmPrd")]
    public Period6Choice_? ClaimPeriod { get; init; }

    /// <summary>
    /// Co Depositories Suspension Period.
    /// </summary>
    [DisplayName("Co Depositories Suspension Period")]
    [IsoXmlTag("CoDpstriesSspnsnPrd")]
    public Period6Choice_? CoDepositoriesSuspensionPeriod { get; init; }

    /// <summary>
    /// Compulsory Purchase Period.
    /// </summary>
    [DisplayName("Compulsory Purchase Period")]
    [IsoXmlTag("CmplsryPurchsPrd")]
    public Period6Choice_? CompulsoryPurchasePeriod { get; init; }

    /// <summary>
    /// Depository Suspension Period For Book Entry Transfer.
    /// </summary>
    [DisplayName("Depository Suspension Period For Book Entry Transfer")]
    [IsoXmlTag("DpstrySspnsnPrdForBookNtryTrf")]
    public Period6Choice_? DepositorySuspensionPeriodForBookEntryTransfer { get; init; }

    /// <summary>
    /// Depository Suspension Period For Deposit.
    /// </summary>
    [DisplayName("Depository Suspension Period For Deposit")]
    [IsoXmlTag("DpstrySspnsnPrdForDpst")]
    public Period6Choice_? DepositorySuspensionPeriodForDeposit { get; init; }

    /// <summary>
    /// Depository Suspension Period For Deposit At Agent.
    /// </summary>
    [DisplayName("Depository Suspension Period For Deposit At Agent")]
    [IsoXmlTag("DpstrySspnsnPrdForDpstAtAgt")]
    public Period6Choice_? DepositorySuspensionPeriodForDepositAtAgent { get; init; }

    /// <summary>
    /// Depository Suspension Period For Pledge.
    /// </summary>
    [DisplayName("Depository Suspension Period For Pledge")]
    [IsoXmlTag("DpstrySspnsnPrdForPldg")]
    public Period6Choice_? DepositorySuspensionPeriodForPledge { get; init; }

    /// <summary>
    /// Depository Suspension Period For Segregation.
    /// </summary>
    [DisplayName("Depository Suspension Period For Segregation")]
    [IsoXmlTag("DpstrySspnsnPrdForSgrtn")]
    public Period6Choice_? DepositorySuspensionPeriodForSegregation { get; init; }

    /// <summary>
    /// Depository Suspension Period For Withdrawal At Agent.
    /// </summary>
    [DisplayName("Depository Suspension Period For Withdrawal At Agent")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlAtAgt")]
    public Period6Choice_? DepositorySuspensionPeriodForWithdrawalAtAgent { get; init; }

    /// <summary>
    /// Depository Suspension Period For Withdrawal In Nominee Name.
    /// </summary>
    [DisplayName("Depository Suspension Period For Withdrawal In Nominee Name")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlInNmneeNm")]
    public Period6Choice_? DepositorySuspensionPeriodForWithdrawalInNomineeName { get; init; }

    /// <summary>
    /// Depository Suspension Period For Withdrawal In Street Name.
    /// </summary>
    [DisplayName("Depository Suspension Period For Withdrawal In Street Name")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlInStrtNm")]
    public Period6Choice_? DepositorySuspensionPeriodForWithdrawalInStreetName { get; init; }

    /// <summary>
    /// Fiscal Year Period.
    /// </summary>
    [DisplayName("Fiscal Year Period")]
    [IsoXmlTag("FsclYrPrd")]
    public Period6Choice_? FiscalYearPeriod { get; init; }

    /// <summary>
    /// Interest Period.
    /// </summary>
    [DisplayName("Interest Period")]
    [IsoXmlTag("IntrstPrd")]
    public Period6Choice_? InterestPeriod { get; init; }

    /// <summary>
    /// Price Calculation Period.
    /// </summary>
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public Period6Choice_? PriceCalculationPeriod { get; init; }

    /// <summary>
    /// Split Period.
    /// </summary>
    [DisplayName("Split Period")]
    [IsoXmlTag("SpltPrd")]
    public Period6Choice_? SplitPeriod { get; init; }
}
