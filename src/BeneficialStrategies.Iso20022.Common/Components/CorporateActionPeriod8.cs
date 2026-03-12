// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies periods of a corporate action.
/// </summary>
[IsoId("_LVRZUfmZEeCJb_jfbljrcg")]
[DisplayName("Corporate Action Period")]
public partial record CorporateActionPeriod8
{
    #nullable enable
    
    /// <summary>
    /// Period during which the price of a security is determined.
    /// </summary>
    [IsoId("_LVRZW_mZEeCJb_jfbljrcg")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public Period3Choice_? PriceCalculationPeriod { get; init; } 
    
    /// <summary>
    /// Period during which the interest rate has been applied.
    /// </summary>
    [IsoId("_LVRZZfmZEeCJb_jfbljrcg")]
    [DisplayName("Interest Period")]
    [IsoXmlTag("IntrstPrd")]
    public Period3Choice_? InterestPeriod { get; init; } 
    
    /// <summary>
    /// Period during a take-over where any outstanding equity must be purchased by the take-over company.
    /// </summary>
    [IsoId("_LVRZb_mZEeCJb_jfbljrcg")]
    [DisplayName("Compulsory Purchase Period")]
    [IsoXmlTag("CmplsryPurchsPrd")]
    public Period3Choice_? CompulsoryPurchasePeriod { get; init; } 
    
    /// <summary>
    /// Period during which the security is blocked.
    /// </summary>
    [IsoId("_LVRZefmZEeCJb_jfbljrcg")]
    [DisplayName("Blocking Period")]
    [IsoXmlTag("BlckgPrd")]
    public Period3Choice_? BlockingPeriod { get; init; } 
    
    /// <summary>
    /// Period assigned by the court in a class action. It determines the client&apos;s eligible transactions that will be included in the class action and used to determine the resulting entitlement.
    /// </summary>
    [IsoId("_LVRZg_mZEeCJb_jfbljrcg")]
    [DisplayName("Claim Period")]
    [IsoXmlTag("ClmPrd")]
    public Period3Choice_? ClaimPeriod { get; init; } 
    
    /// <summary>
    /// Period defining the last date for which book entry transfers will be accepted and the date on which the suspension will be released and book entry transfer processing will resume.
    /// </summary>
    [IsoId("_LVRZjfmZEeCJb_jfbljrcg")]
    [DisplayName("Depository Suspension Period For Book Entry Transfer")]
    [IsoXmlTag("DpstrySspnsnPrdForBookNtryTrf")]
    public Period3Choice_? DepositorySuspensionPeriodForBookEntryTransfer { get; init; } 
    
    /// <summary>
    /// Period defining the last date for which deposits, into nominee name, at the agent will be accepted and the date on which the suspension will be released and deposits at agent will resume.
    /// </summary>
    [IsoId("_LVRZl_mZEeCJb_jfbljrcg")]
    [DisplayName("Depository Suspension Period For Deposit At Agent")]
    [IsoXmlTag("DpstrySspnsnPrdForDpstAtAgt")]
    public Period3Choice_? DepositorySuspensionPeriodForDepositAtAgent { get; init; } 
    
    /// <summary>
    /// Period defining the last date for which deposits will be accepted and the date on which the suspension will be released and deposits will resume.
    /// </summary>
    [IsoId("_LVRZofmZEeCJb_jfbljrcg")]
    [DisplayName("Depository Suspension Period For Deposit")]
    [IsoXmlTag("DpstrySspnsnPrdForDpst")]
    public Period3Choice_? DepositorySuspensionPeriodForDeposit { get; init; } 
    
    /// <summary>
    /// Period defining the last date for which pledges will be accepted and the date on which the suspension will be released and pledge processing will resume.
    /// </summary>
    [IsoId("_LVRZq_mZEeCJb_jfbljrcg")]
    [DisplayName("Depository Suspension Period For Pledge")]
    [IsoXmlTag("DpstrySspnsnPrdForPldg")]
    public Period3Choice_? DepositorySuspensionPeriodForPledge { get; init; } 
    
    /// <summary>
    /// Period defining the last date for which intra-position balances can be segregated and the date on which the suspension will be released and the ability to segregate intra-position balances will resume.
    /// </summary>
    [IsoId("_LVRZtfmZEeCJb_jfbljrcg")]
    [DisplayName("Depository Suspension Period For Segregation")]
    [IsoXmlTag("DpstrySspnsnPrdForSgrtn")]
    public Period3Choice_? DepositorySuspensionPeriodForSegregation { get; init; } 
    
    /// <summary>
    /// Period defining the last date for which withdrawals, from nominee name at the agent will be accepted and the date on which the suspension will be released and withdrawals at agent processing will resume.
    /// </summary>
    [IsoId("_LVRZv_mZEeCJb_jfbljrcg")]
    [DisplayName("Depository Suspension Period For Withdrawal At Agent")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlAtAgt")]
    public Period3Choice_? DepositorySuspensionPeriodForWithdrawalAtAgent { get; init; } 
    
    /// <summary>
    /// Period defining the last date for which physical withdrawals in the nominee&apos;s name will be accepted and the date on which the suspension will be released and physical withdrawals in the nominee&apos;s name will resume.
    /// </summary>
    [IsoId("_LVRZyfmZEeCJb_jfbljrcg")]
    [DisplayName("Depository Suspension Period For Withdrawal In Nominee Name")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlInNmneeNm")]
    public Period3Choice_? DepositorySuspensionPeriodForWithdrawalInNomineeName { get; init; } 
    
    /// <summary>
    /// Period defining the last date on which withdrawal requests in street name&apos;s will be accepted on the event security and the date on which the suspension will be released and withdrawal in street name&apos;s processing on the event security will resume.
    /// </summary>
    [IsoId("_LVRZ0_mZEeCJb_jfbljrcg")]
    [DisplayName("Depository Suspension Period For Withdrawal In Street Name")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwlInStrtNm")]
    public Period3Choice_? DepositorySuspensionPeriodForWithdrawalInStreetName { get; init; } 
    
    /// <summary>
    /// Period defining the last date on which shareholder registration will be accepted by the issuer and the date on which shareholder registration will resume.
    /// </summary>
    [IsoId("_LVRZ3fmZEeCJb_jfbljrcg")]
    [DisplayName("Book Closure Period")]
    [IsoXmlTag("BookClsrPrd")]
    public Period3Choice_? BookClosurePeriod { get; init; } 
    
    /// <summary>
    /// Period during which the settlement activities at the co-depositories are suspended in order to stabilise the holdings at the CSD.
    /// </summary>
    [IsoId("_LiFtZfmZEeCJb_jfbljrcg")]
    [DisplayName("Co Depositories Suspension Period")]
    [IsoXmlTag("CoDpstriesSspnsnPrd")]
    public Period3Choice_? CoDepositoriesSuspensionPeriod { get; init; } 
    
    
    #nullable disable
    
}
