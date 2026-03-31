// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies periods of a corporate action.
/// </summary>
[IsoId("_TZlwBdp-Ed-ak6NoX_4Aeg_635105711")]
[DisplayName("Corporate Action Period")]
public record CorporateActionPeriod3
{
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_TZlwBtp-Ed-ak6NoX_4Aeg_643414438")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public Period1Choice_? PriceCalculationPeriod { get; init; }

    /// <summary>
    /// Period during which the interest rate has been applied.
    /// </summary>
    [IsoId("_TZlwB9p-Ed-ak6NoX_4Aeg_635106185")]
    [DisplayName("Interest Period")]
    [IsoXmlTag("IntrstPrd")]
    public Period1Choice_? InterestPeriod { get; init; }

    /// <summary>
    /// Period during a take-over where any outstanding equity must be purchased by the take-over company.
    /// </summary>
    [IsoId("_TZvhANp-Ed-ak6NoX_4Aeg_635106125")]
    [DisplayName("Compulsory Purchase Period")]
    [IsoXmlTag("CmplsryPurchsPrd")]
    public Period1Choice_? CompulsoryPurchasePeriod { get; init; }

    /// <summary>
    /// Period during which the security is blocked.
    /// </summary>
    [IsoId("_TZvhAdp-Ed-ak6NoX_4Aeg_635105796")]
    [DisplayName("Blocking Period")]
    [IsoXmlTag("BlckgPrd")]
    public Period1Choice_? BlockingPeriod { get; init; }

    /// <summary>
    /// Period assigned by the court in a class action. It determines the client&apos;s eligible transactions that will be included in the class action and used to determine the resulting entitlement.
    /// </summary>
    [IsoId("_TZvhAtp-Ed-ak6NoX_4Aeg_1015593443")]
    [DisplayName("Claim Period")]
    [IsoXmlTag("ClmPrd")]
    public Period1Choice_? ClaimPeriod { get; init; }

    /// <summary>
    /// Period defining the last date for which book entry transfers will be accepted and the date on which the suspension will be released and book entry transfer processing will resume.
    /// </summary>
    [IsoId("_TZvhA9p-Ed-ak6NoX_4Aeg_1077194615")]
    [DisplayName("Depository Suspension Period For Book Entry Transfer")]
    [IsoXmlTag("DpstrySspnsnPrdForBookNtryTrf")]
    public Period1Choice_? DepositorySuspensionPeriodForBookEntryTransfer { get; init; }

    /// <summary>
    /// Period defining the last date for which deposits, into nominee name, at the agent will be accepted and the date on which the suspension will be released and deposits at agent will resume.
    /// </summary>
    [IsoId("_TZvhBNp-Ed-ak6NoX_4Aeg_1407816466")]
    [DisplayName("Depository Suspension Period For Deposit At Agent")]
    [IsoXmlTag("DpstrySspnsnPrdForDpstAtAgt")]
    public Period1Choice_? DepositorySuspensionPeriodForDepositAtAgent { get; init; }

    /// <summary>
    /// Period defining the last date for which deposits will be accepted and the date on which the suspension will be released and deposits will resume.
    /// </summary>
    [IsoId("_TZvhBdp-Ed-ak6NoX_4Aeg_1463228591")]
    [DisplayName("Depository Suspension Period For Deposit")]
    [IsoXmlTag("DpstrySspnsnPrdForDpst")]
    public Period1Choice_? DepositorySuspensionPeriodForDeposit { get; init; }

    /// <summary>
    /// Period defining the last date for which pledges will be accepted and the date on which the suspension will be released and pledge processing will resume.
    /// </summary>
    [IsoId("_TZvhBtp-Ed-ak6NoX_4Aeg_1519561963")]
    [DisplayName("Depository Suspension Period For Pledge")]
    [IsoXmlTag("DpstrySspnsnPrdForPldg")]
    public Period1Choice_? DepositorySuspensionPeriodForPledge { get; init; }

    /// <summary>
    /// Period defining the last date for which intra-position balances can be segregated and the date on which the suspension will be released and the ability to segregate intra-position balances will resume.
    /// </summary>
    [IsoId("_TZvhB9p-Ed-ak6NoX_4Aeg_1647006341")]
    [DisplayName("Depository Suspension Period For Segregation")]
    [IsoXmlTag("DpstrySspnsnPrdForSgrtn")]
    public Period1Choice_? DepositorySuspensionPeriodForSegregation { get; init; }

    /// <summary>
    /// Period defining the last date for which withdrawals, from nominee name at the agent will be accepted and the date on which the suspension will be released and withdrawals at agent processing will resume.
    /// </summary>
    [IsoId("_TZvhCNp-Ed-ak6NoX_4Aeg_1924064084")]
    [DisplayName("Depository Suspension Period For Withdrawal At Agent")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlAtAgt")]
    public Period1Choice_? DepositorySuspensionPeriodForWithdrawalAtAgent { get; init; }

    /// <summary>
    /// Period defining the last date for which physical withdrawals in the nominee&apos;s name will be accepted and the date on which the suspension will be released and physical withdrawals in the nominee&apos;s name will resume.
    /// </summary>
    [IsoId("_TZvhCdp-Ed-ak6NoX_4Aeg_1997946852")]
    [DisplayName("Depository Suspension Period For Withdrawal In Nominee Name")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlInNmneeNm")]
    public Period1Choice_? DepositorySuspensionPeriodForWithdrawalInNomineeName { get; init; }

    /// <summary>
    /// Period defining the last date on which withdrawal requests in street name&apos;s will be accepted on the event security and the date on which the suspension will be released and withdrawal in street name&apos;s processing on the event security will resume.
    /// </summary>
    [IsoId("_TZ4q8Np-Ed-ak6NoX_4Aeg_-2002418252")]
    [DisplayName("Depository Suspension Period For Withdrawal In Street Name")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlInStrtNm")]
    public Period1Choice_? DepositorySuspensionPeriodForWithdrawalInStreetName { get; init; }

    /// <summary>
    /// Period defining the last date on which shareholder registration will be accepted by the issuer and the date on which shareholder registration will resume.
    /// </summary>
    [IsoId("_TZ4q8dp-Ed-ak6NoX_4Aeg_91986466")]
    [DisplayName("Book Closure Period")]
    [IsoXmlTag("BookClsrPrd")]
    public Period1Choice_? BookClosurePeriod { get; init; }
}
