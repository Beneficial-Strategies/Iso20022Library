// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the periods related to a corporate action option.
/// </summary>
[IsoId("_x14REatmEfCqjuqNaaNXgw")]
[DisplayName("Corporate Action Period17")]
public record CorporateActionPeriod17
{
    /// <summary>
    /// Period during which the interest rate applicable to the coupon payment has been calculated.
    /// </summary>
    [IsoId("_yFQqEatmEfCqjuqNaaNXgw")]
    [DisplayName("Interest Period")]
    [IsoXmlTag("IntrstPrd")]
    public Period12Choice_? InterestPeriod { get; init; }

    /// <summary>
    /// Period during which the offeror can purchase the shares from the holders.
    /// </summary>
    [IsoId("_yFQqEqtmEfCqjuqNaaNXgw")]
    [DisplayName("Compulsory Purchase Period")]
    [IsoXmlTag("CmplsryPurchsPrd")]
    public Period12Choice_? CompulsoryPurchasePeriod { get; init; }

    /// <summary>
    /// Period assigned for the purpose of claiming entitlements.
    /// </summary>
    [IsoId("_yFQqE6tmEfCqjuqNaaNXgw")]
    [DisplayName("Claim Period")]
    [IsoXmlTag("ClmPrd")]
    public Period12Choice_? ClaimPeriod { get; init; }

    /// <summary>
    /// Period during which the depository suspends the book entry transfer of a security.
    /// </summary>
    [IsoId("_yFQqFKtmEfCqjuqNaaNXgw")]
    [DisplayName("Depository Suspension Period For Book Entry Transfer")]
    [IsoXmlTag("DpstrySspnsnPrdForBookNtryTrf")]
    public Period12Choice_? DepositorySuspensionPeriodForBookEntryTransfer { get; init; }

    /// <summary>
    /// Period during which the depository suspends deposit of a security at the agent.
    /// </summary>
    [IsoId("_yFQqFatmEfCqjuqNaaNXgw")]
    [DisplayName("Depository Suspension Period For Deposit At Agent")]
    [IsoXmlTag("DpstrySspnsnPrdForDpstAtAgt")]
    public Period12Choice_? DepositorySuspensionPeriodForDepositAtAgent { get; init; }

    /// <summary>
    /// Period during which the depository suspends deposit of a security.
    /// </summary>
    [IsoId("_yFQqFqtmEfCqjuqNaaNXgw")]
    [DisplayName("Depository Suspension Period For Deposit")]
    [IsoXmlTag("DpstrySspnsnPrdForDpst")]
    public Period12Choice_? DepositorySuspensionPeriodForDeposit { get; init; }

    /// <summary>
    /// Period during which the depository suspends pledge of a security.
    /// </summary>
    [IsoId("_yFQqF6tmEfCqjuqNaaNXgw")]
    [DisplayName("Depository Suspension Period For Pledge")]
    [IsoXmlTag("DpstrySspnsnPrdForPldg")]
    public Period12Choice_? DepositorySuspensionPeriodForPledge { get; init; }

    /// <summary>
    /// Period during which the depository suspends segregation of a security.
    /// </summary>
    [IsoId("_yFQqGKtmEfCqjuqNaaNXgw")]
    [DisplayName("Depository Suspension Period For Segregation")]
    [IsoXmlTag("DpstrySspnsnPrdForSgrtn")]
    public Period12Choice_? DepositorySuspensionPeriodForSegregation { get; init; }

    /// <summary>
    /// Period during which the depository suspends withdrawal of a security at agent.
    /// </summary>
    [IsoId("_yFQqGatmEfCqjuqNaaNXgw")]
    [DisplayName("Depository Suspension Period For Withdrawal At Agent")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlAtAgt")]
    public Period12Choice_? DepositorySuspensionPeriodForWithdrawalAtAgent { get; init; }

    /// <summary>
    /// Period during which the depository suspends withdrawal of a security in nominee name.
    /// </summary>
    [IsoId("_yFQqGqtmEfCqjuqNaaNXgw")]
    [DisplayName("Depository Suspension Period For Withdrawal In Nominee Name")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlInNmneeNm")]
    public Period12Choice_? DepositorySuspensionPeriodForWithdrawalInNomineeName { get; init; }

    /// <summary>
    /// Period during which the depository suspends withdrawal of a security in street name.
    /// </summary>
    [IsoId("_yFQqG6tmEfCqjuqNaaNXgw")]
    [DisplayName("Depository Suspension Period For Withdrawal In Street Name")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlInStrtNm")]
    public Period12Choice_? DepositorySuspensionPeriodForWithdrawalInStreetName { get; init; }

    /// <summary>
    /// Period during which the books of the issuer are closed.
    /// </summary>
    [IsoId("_yFQqHKtmEfCqjuqNaaNXgw")]
    [DisplayName("Book Closure Period")]
    [IsoXmlTag("BookClsrPrd")]
    public Period12Choice_? BookClosurePeriod { get; init; }

    /// <summary>
    /// Period during which co-depositories suspend the transfer of a security.
    /// </summary>
    [IsoId("_yFQqHatmEfCqjuqNaaNXgw")]
    [DisplayName("Co Depositories Suspension Period")]
    [IsoXmlTag("CoDpstriesSspnsnPrd")]
    public Period12Choice_? CoDepositoriesSuspensionPeriod { get; init; }

    /// <summary>
    /// Period during which the security is to be split.
    /// </summary>
    [IsoId("_yFQqHqtmEfCqjuqNaaNXgw")]
    [DisplayName("Split Period")]
    [IsoXmlTag("SpltPrd")]
    public Period12Choice_? SplitPeriod { get; init; }

    /// <summary>
    /// Fiscal year of the income to be distributed.
    /// </summary>
    [IsoId("_yFQqH6tmEfCqjuqNaaNXgw")]
    [DisplayName("Fiscal Year Period")]
    [IsoXmlTag("FsclYrPrd")]
    public Period12Choice_? FiscalYearPeriod { get; init; }
}
