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
[IsoId("_f6Wace2-Eeqc-LCjwLsUVg")]
[DisplayName("Corporate Action Period")]
public record CorporateActionPeriod15
{
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_gOuvBe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public Period6Choice_? PriceCalculationPeriod { get; init; }

    /// <summary>
    /// Period during which the interest rate has been applied.
    /// </summary>
    [IsoId("_gOuvDe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Interest Period")]
    [IsoXmlTag("IntrstPrd")]
    public Period6Choice_? InterestPeriod { get; init; }

    /// <summary>
    /// Period during a take-over where any outstanding equity must be purchased by the take-over company.
    /// </summary>
    [IsoId("_gOuvFe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Compulsory Purchase Period")]
    [IsoXmlTag("CmplsryPurchsPrd")]
    public Period6Choice_? CompulsoryPurchasePeriod { get; init; }

    /// <summary>
    /// Period assigned by the court in a class action. It determines the client&apos;s eligible transactions that will be included in the class action and used to determine the resulting entitlement.
    /// </summary>
    [IsoId("_gOuvJe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Claim Period")]
    [IsoXmlTag("ClmPrd")]
    public Period6Choice_? ClaimPeriod { get; init; }

    /// <summary>
    /// Period defining the last date for which book entry transfers will be accepted and the date on which the suspension will be released and book entry transfer processing will resume.
    /// </summary>
    [IsoId("_gOuvLe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Depository Suspension Period For Book Entry Transfer")]
    [IsoXmlTag("DpstrySspnsnPrdForBookNtryTrf")]
    public Period6Choice_? DepositorySuspensionPeriodForBookEntryTransfer { get; init; }

    /// <summary>
    /// Period defining the last date for which deposits, into nominee name, at the agent will be accepted and the date on which the suspension will be released and deposits at agent will resume.
    /// </summary>
    [IsoId("_gOuvNe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Depository Suspension Period For Deposit At Agent")]
    [IsoXmlTag("DpstrySspnsnPrdForDpstAtAgt")]
    public Period6Choice_? DepositorySuspensionPeriodForDepositAtAgent { get; init; }

    /// <summary>
    /// Period defining the last date for which deposits will be accepted and the date on which the suspension will be released and deposits will resume.
    /// </summary>
    [IsoId("_gOuvPe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Depository Suspension Period For Deposit")]
    [IsoXmlTag("DpstrySspnsnPrdForDpst")]
    public Period6Choice_? DepositorySuspensionPeriodForDeposit { get; init; }

    /// <summary>
    /// Period defining the last date for which pledges will be accepted and the date on which the suspension will be released and pledge processing will resume.
    /// </summary>
    [IsoId("_gOuvRe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Depository Suspension Period For Pledge")]
    [IsoXmlTag("DpstrySspnsnPrdForPldg")]
    public Period6Choice_? DepositorySuspensionPeriodForPledge { get; init; }

    /// <summary>
    /// Period defining the last date for which intra-position balances can be segregated and the date on which the suspension will be released and the ability to segregate intra-position balances will resume.
    /// </summary>
    [IsoId("_gOuvTe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Depository Suspension Period For Segregation")]
    [IsoXmlTag("DpstrySspnsnPrdForSgrtn")]
    public Period6Choice_? DepositorySuspensionPeriodForSegregation { get; init; }

    /// <summary>
    /// Period defining the last date for which withdrawals, from nominee name at the agent will be accepted and the date on which the suspension will be released and withdrawals at agent processing will resume.
    /// </summary>
    [IsoId("_gOuvVe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Depository Suspension Period For Withdrawal At Agent")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlAtAgt")]
    public Period6Choice_? DepositorySuspensionPeriodForWithdrawalAtAgent { get; init; }

    /// <summary>
    /// Period defining the last date for which physical withdrawals in the nominee&apos;s name will be accepted and the date on which the suspension will be released and physical withdrawals in the nominee&apos;s name will resume.
    /// </summary>
    [IsoId("_gOuvXe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Depository Suspension Period For Withdrawal In Nominee Name")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlInNmneeNm")]
    public Period6Choice_? DepositorySuspensionPeriodForWithdrawalInNomineeName { get; init; }

    /// <summary>
    /// Period defining the last date on which withdrawal requests in street name&apos;s will be accepted on the event security and the date on which the suspension will be released and withdrawal in street name&apos;s processing on the event security will resume.
    /// </summary>
    [IsoId("_gOuvZe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Depository Suspension Period For Withdrawal In Street Name")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlInStrtNm")]
    public Period6Choice_? DepositorySuspensionPeriodForWithdrawalInStreetName { get; init; }

    /// <summary>
    /// Period defining the last date on which shareholder registration will be accepted by the issuer and the date on which shareholder registration will resume.
    /// </summary>
    [IsoId("_gOuvbe2-Eeqc-LCjwLsUVg")]
    [DisplayName("Book Closure Period")]
    [IsoXmlTag("BookClsrPrd")]
    public Period6Choice_? BookClosurePeriod { get; init; }

    /// <summary>
    /// Period during which the settlement activities at the co-depositories are suspended in order to stabilise the holdings at the CSD.
    /// </summary>
    [IsoId("_gOuvde2-Eeqc-LCjwLsUVg")]
    [DisplayName("Co Depositories Suspension Period")]
    [IsoXmlTag("CoDpstriesSspnsnPrd")]
    public Period6Choice_? CoDepositoriesSuspensionPeriod { get; init; }

    /// <summary>
    /// Period during which a physical certificate can be split.
    /// </summary>
    [IsoId("_gOuvd-2-Eeqc-LCjwLsUVg")]
    [DisplayName("Split Period")]
    [IsoXmlTag("SpltPrd")]
    public Period6Choice_? SplitPeriod { get; init; }
}
